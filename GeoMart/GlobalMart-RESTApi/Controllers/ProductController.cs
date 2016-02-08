using GlobalMart_Domain.Entities;
using GlobalMart_RESTApi.Filters;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlobalMart_RESTApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        public ProductController()
        {
        }

        public ProductController(IProductService studyService)
        {
            _productService = studyService;        
        }


        [HttpGet]
        [Route("api/v1/study/getproducts")]
        [AllowCrossSiteJson]
        public IHttpActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [AllowCrossSiteJson]
        public IHttpActionResult GetProductbyId(int id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult GetProductbyId(Product objProduct)
        {
           _productService.Add(objProduct);
            return Ok(objProduct);
        }
    }
}
