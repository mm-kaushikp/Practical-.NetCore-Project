using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RangeValidation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(rangeValidation model, string btnClick)
        {
            if (ModelState.IsValid && btnClick == "Submit")
            {
                ViewBag.Age = model.Age;
            }
            else if (btnClick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
