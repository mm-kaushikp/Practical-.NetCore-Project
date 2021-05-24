using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CompareValidation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(compareValidation model, string btnClick)
        {
            if (ModelState.IsValid && btnClick == "Submit")
            {
                ViewBag.Password = model.Password;
                ViewBag.ConfirmPassword = model.ConfirmPassword;
            }
            else if (btnClick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
