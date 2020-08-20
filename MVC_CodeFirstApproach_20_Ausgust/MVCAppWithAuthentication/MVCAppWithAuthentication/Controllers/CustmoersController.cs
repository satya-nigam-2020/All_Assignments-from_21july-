using MVCAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            var customers = _context.customers.Include(c=>c.
            MemberShipType).ToList();
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
    }
}