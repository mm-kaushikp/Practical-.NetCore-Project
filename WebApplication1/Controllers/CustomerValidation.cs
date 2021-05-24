using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerValidation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(customerValidation model, string btnClick)
        {
            if (ModelState.IsValid && btnClick == "Submit")
            {
                ViewBag.Comment = model.comment;
            }
            else if (btnClick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
