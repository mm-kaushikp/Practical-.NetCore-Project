using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class MasterPage : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your application home page.";
            return View();
        }

        public ActionResult ContactPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AboutPage()
        {
            ViewBag.Message = "Your About page.";
            return View();
        }

        
    }
}
