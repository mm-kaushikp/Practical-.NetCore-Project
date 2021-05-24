using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Login : Controller
    {
        private LoginDbContext db = new LoginDbContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Registration registration)
        {
            var obj = db.registrations.Where(a => a.FirstName.Equals(registration.FirstName) && a.Password.Equals(registration.Password)).FirstOrDefault();
            if (obj != null)
            {
                return RedirectToAction("DashBoard");
            }
            return View(registration);
        }

        public ActionResult DashBoard()
        {
            return View();
        }
    }
}
