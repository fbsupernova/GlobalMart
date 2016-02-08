using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlobalMart_RESTApi.Controllers
{
    public class ClientController : ApiController
    {
        private readonly IClientService _clientService;
        public ClientController()
        {
        }

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }


        [HttpGet]
        public IHttpActionResult GetProductbyId(int id)
        {
            var product = _clientService.GetClients(id);
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult GetProductbyId(Product objProduct)
        {
            _clientService.Add(objProduct);
            return Ok(objProduct);
        }
    }
}
