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
    public class EmployeInformation : Controller
    {
        private LoginDbContext db = new LoginDbContext();

        // GET: EmployeInformation
        public ActionResult Index()
        {
            return View(db.employeInformation.ToList());
        }

        // GET: EmployeInformation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
            }
            employeInformation empInfo = db.employeInformation.Find(id);
            if (empInfo == null)
            {
            }
            return View();
        }

        // GET: EmployeInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeInformation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(employeInformation model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.employeInformation.Add(model);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator");
            }
            return View(model);
        }

        // GET: EmployeInformation/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.employeInformation.Where(a => a.EmployeId == id).FirstOrDefault());
        }

        // POST: EmployeInformation/Edit/5
        [HttpPost]
        public ActionResult Edit(employeInformation model)
        {
            db.employeInformation.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: EmployeInformation/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.employeInformation.Where(a => a.EmployeId == id).FirstOrDefault());
        }

        // POST: EmployeInformation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,employeInformation emp)
        {
            var empInfo = db.employeInformation.Where(a => a.EmployeId == id).FirstOrDefault();
            db.employeInformation.Remove(empInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
