using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegularExpression : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(regularExpression model, string btnClick)
        {
            if (ModelState.IsValid && btnClick == "Submit")
            {
                ViewBag.Email = model.Email;
            }
            else if (btnClick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
