using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectPersonelSystem.Repositories;
using ProjectPersonelSystem.Models;

namespace ProjectPersonelSystem.Controllers
{
    public class MailController : Controller
    {
        MessageHandler msghandler = new MessageHandler();

        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mail/Create
        [HttpPost]
        public ActionResult Create(Mail mail)
        {
            try
            {
                // TODO: Add insert logic here
                mail.DeliveryDate = DateTime.Now;

                msghandler.SendMessage(mail);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mail/Edit/5
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

        // GET: Mail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mail/Delete/5
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
