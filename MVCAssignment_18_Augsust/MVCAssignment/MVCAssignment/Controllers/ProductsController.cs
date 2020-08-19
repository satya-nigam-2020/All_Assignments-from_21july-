using MVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = GetProductDetails();

            return View(product);
        }

        public IEnumerable<Product> GetProductDetails()
        {
            return new List<Product>
            {
                new Product{Product_Id=101, Product_Name="AC", Rate=45000},
                 new Product{Product_Id=102, Product_Name="Mobile", Rate=38000},
                  new Product{Product_Id=103, Product_Name="Bike", Rate=94000}
            };

        }

        public ActionResult Details(int id)
        {
            var pro = GetProductDetails().SingleOrDefault(c => c.Product_Id == id);
            if (pro == null)
                return HttpNotFound();
            return View(pro);
        }
    }
}