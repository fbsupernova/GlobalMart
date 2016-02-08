using AutoMapper;
using GlobalMart_Domain.Entities;
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

        public ActionResult Index()
        {
            var productModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductVM>>(_productService.GetProducts());
            return View(productModel);
          
        }
    }
}