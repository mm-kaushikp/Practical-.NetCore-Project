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
    public class UserRegistration : Controller
    {
        private LoginDbContext db = new LoginDbContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.registrations.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator");
            }
            return View(model);
        }
    }
}
