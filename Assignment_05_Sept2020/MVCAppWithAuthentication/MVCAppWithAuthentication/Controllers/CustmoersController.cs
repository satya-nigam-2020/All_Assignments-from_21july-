using MVCAppWithAuthentication.Models;
using MVCAppWithAuthentication.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCAppWithAuthentication.Controllers
{
    public class CustmoersController : Controller
    {
        private ApplicationDbContext _context;
            
        public CustmoersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Custmoers
        public ActionResult Index()
        {
            IEnumerable<Customers> customers;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Customers").Result;
            customers = response.Content.ReadAsAsync<IEnumerable<Customers>>().Result;
            //var customers = _context.customers.Include(c=>c.
            //MemberShipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var singleCustomer = _context.customers.Include(c => c.
            MemberShipType).SingleOrDefault(c => c.Id==id);
            if(singleCustomer==null)
            {
                return HttpNotFound();
            }
            return View(singleCustomer);
        }
        public ActionResult Create()
        {
            var membershipTypes = _context.MemberShipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                memberShipTypes = membershipTypes
            };
            return View(viewModel);
        }
        //[HttpPost]
        //public ActionResult Create(Customers customer) //Model Binding
        //{
        //    _context.customers.Add(customer);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Custmoers");
        //}


        [HttpPost]
        public ActionResult Save(Customers customer) //Model Binding
        {
            if (customer.Id == 0)
            {
                _context.customers.Add(customer);
               
            }
            else
            {
                var customerInDb = _context.customers.Single(
                    c=>c.Id==customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.DateOfBirth = customer.DateOfBirth;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter =
                    customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Custmoers");
        }


        public ActionResult Edit(int id)
        {
            var updateCust = _context.customers.SingleOrDefault(
                c => c.Id == id);
            if (updateCust == null)
            {
                return HttpNotFound();
            }
            var vm = new NewCustomerViewModel
            {
                Customer = updateCust,
                memberShipTypes = _context.MemberShipTypes.ToList()
            };
            return View("Create",vm);
        }
    }
}