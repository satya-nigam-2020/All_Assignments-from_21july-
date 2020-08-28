﻿using BethanyPieShop2.Models;
using BethanyPieShop2.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BethanyPieShop2.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        DbContextClass _context;
        public ProductDetailsController()
        {
            _context = new DbContextClass();
        }
        // GET: ProductDetails
        public ActionResult Index()
        {
            var products = _context.ProductDetails.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var singleProduct = _context.ProductDetails.SingleOrDefault(k => k.ProductId == id);
            if (singleProduct == null)
                return HttpNotFound();
            return View(singleProduct);
        }

        public ActionResult Update(int? id)
        {
            var updateProduct = _context.ProductDetails.SingleOrDefault(c => c.ProductId == id);
            if (updateProduct == null)
            {
                return HttpNotFound();
            }
            var up = new ProDetailsAndCatagory
            {
                ProductDetail = updateProduct,
                Catagories = _context.Categories.ToList()
            };
            return View("Create", up);
        }

        public ActionResult Create()
        {
            var newCatagory = _context.Categories.ToList();
            var viewModel = new ProDetailsAndCatagory
            {
                Catagories = newCatagory
                //ProductDetail = new ProductDetail()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(ProductDetail product)
        {
            _context.ProductDetails.Add(product);                      // Data Binding
            //_context.Set<ProductDetail>().AddOrUpdate(product);
            _context.SaveChanges();
            //try
            //{
            //	_context.SaveChanges();
            //}
            //catch (DbEntityValidationException e)
            //{
            //             Console.WriteLine(e);
            //}

            return RedirectToAction("Index", "ProductDetails");
        }
        //[HttpPost]
        //public ActionResult Save(ProductDetail product)
        //{
        //    if (product.ProductId == 0)
        //    {
        //        _context.ProductDetails.Add(product);

        //    }
        //    else
        //    {
        //        var productInDb = _context.ProductDetails.Single(c => c.ProductId == product.ProductId);
        //        productInDb.ProductName = product.ProductName;
        //        productInDb.ShortDescription = product.ShortDescription;
        //        productInDb.LongDescription = product.LongDescription;
        //        productInDb.Price = product.Price;
        //        productInDb.Image = product.Image;
        //        productInDb.CatagoryId = product.CatagoryId;
        //    }
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Users");
        //}

        public ActionResult Delete(int? id)
        {
            var selectProduct = _context.ProductDetails.SingleOrDefault(c => c.ProductId == id);
            if (selectProduct == null)
                return HttpNotFound();
            _context.ProductDetails.Remove(selectProduct);
            _context.SaveChanges();
            return RedirectToAction("Index", "ProductDetails");
        }
    }
}