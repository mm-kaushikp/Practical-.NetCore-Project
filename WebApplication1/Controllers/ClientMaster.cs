using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientMaster : Controller
    {
        private LoginDbContext db = new LoginDbContext();

        // GET: ClientMaster
        public ActionResult Index()
        {
            return View(db.clientMasters.ToList());
        }

        // GET: ClientMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientMaster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(clientMaster clientMaster)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.clientMasters.Add(clientMaster);
                    db.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator");
            }
            return View(clientMaster);

        }

        // GET: ClientMaster/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.clientMasters.Where(c => c.ClientId == id).FirstOrDefault());
        }

        // POST: ClientMaster/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(clientMaster model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.clientMasters.Update(model);
                    db.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientMaster/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.clientMasters.Where(a => a.ClientId == id).FirstOrDefault());
        }

        // POST: ClientMaster/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var objClientMaster = db.clientMasters.Where(a => a.ClientId == id).FirstOrDefault();
            db.clientMasters.Remove(objClientMaster);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
