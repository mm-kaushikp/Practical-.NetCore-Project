using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebApplication1.Controllers
{
    public class CustomerEntery : Controller
    {
        private LoginDbContext db = new LoginDbContext();
        // GET: CustomerEntery
        public ActionResult Index()
        {
            return View();
        }

        // POST: CustomerEntery/Create
        [HttpPost]
        public ActionResult Index(customerEntery customerEntery, string btnClick)
        {
            try
            {
                if (ModelState.IsValid && btnClick == "Submit")
                {
                    db.customerEnteries.Add(customerEntery);
                    db.SaveChanges();
                }
                else if (btnClick == "Reset")
                {
                    ModelState.Clear();
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator");
            }
            return View(customerEntery);

        }
    }
}
