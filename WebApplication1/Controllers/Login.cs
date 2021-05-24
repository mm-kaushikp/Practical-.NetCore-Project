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
        public async Task<IActionResult> Index(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                var obj = db.loginModels.Where(a => a.UserName.Equals(user.UserName) && a.Password.Equals(user.Password)).FirstOrDefault();
                if (obj != null)
                {
                    return RedirectToAction("DashBoard");
                }
            }
            return View(user);
        }

        public ActionResult DashBoard()
        {
            return View();
        }
    }
}
