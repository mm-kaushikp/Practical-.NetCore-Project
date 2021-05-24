using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DatePicker : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(datePicker model)
        {
            ViewBag.Date = model.Date.ToString("dd-MMMM-yyyy");
            return View(model);
        }
    }
}
