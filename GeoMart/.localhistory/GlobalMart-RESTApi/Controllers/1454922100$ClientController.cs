using GlobalMart_Domain.Entities;
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
            var client = _clientService.GetClientById(id);
            return Ok(client);
        }

        [HttpPost]
        public IHttpActionResult GetClientbyId(Client objClient)
        {
            _clientService.Add(objClient);
            return Ok(objClient);
        }
    }
}
