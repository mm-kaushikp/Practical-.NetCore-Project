using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class StringOperation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string value, string stringValue)
        {
            if (stringValue == "UpperCase")
            {
                ViewBag.value = value.ToUpper();
            }
            else if (stringValue == "LowerCase")
            {
                ViewBag.value = value.ToLower();
            }
            else if (stringValue == "rfc")
            {
                ViewBag.value = value.Substring(value.Length - 5);
            }
            else if (stringValue == "lfc")
            {
                ViewBag.value = value.Substring(0, 5);
            }
            return View();
        }
    }
}
