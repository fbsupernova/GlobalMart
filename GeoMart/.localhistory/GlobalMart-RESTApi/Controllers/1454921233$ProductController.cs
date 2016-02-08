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
        public IHttpActionResult GetProductbyId(int id)
        {
            var study = _productService.GetProductById(id);
            return Ok(study);
        }


    }
}
