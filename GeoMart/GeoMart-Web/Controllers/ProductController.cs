using AutoMapper;
using GlobalMart_Domain.Entities;
using GlobalMartWeb.Attibutes;
using GlobalMartWeb.VMModels;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalMartWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private readonly ProductService _productService = new ProductService();

        [AllowCrossSiteJsonAttribute]
        public ActionResult Index()
        {
            var productModels = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductVM>>(_productService.GetProducts());
            return View(productModels);
          
        }

        public ActionResult GetProductById(int id)
        {
            var productModel = Mapper.Map<Product,ProductVM>(_productService.GetProductById(id));
            return View("ProductDetails");
          

        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductVM productobj)
        {
            if (ModelState.IsValid)
            {
                var client = Mapper.Map<ProductVM, Product>(productobj);
                _productService.Add(client);
                return RedirectToAction("Index");
            }
            return View(productobj);
        }


    }
}