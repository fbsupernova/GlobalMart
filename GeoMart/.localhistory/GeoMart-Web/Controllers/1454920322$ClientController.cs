using GlobalMart_Infra_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GlobalMart_Domain.Entities;
using GlobalMartWeb.VMModels;

namespace GlobalMartWeb.Controllers
{
    public class ClientController : Controller
    {


        private readonly ClientRepository _clientRepo = new ClientRepository();
        // GET: Client
        public ActionResult Index()
        {
            var clientModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientVM>>(_clientRepo.GetAll());
            return View(clientModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientVM clientobj)
        {
            if(ModelState.IsValid)
            {
                var client = Mapper.Map<ClientVM, Client>(clientobj);
                _clientRepo.Add(client);
                return RedirectToAction("Index");
            }
            return View(clientobj);
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
