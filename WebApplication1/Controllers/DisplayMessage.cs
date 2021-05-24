using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DisplayMessage : Controller
    {
        // GET: Display Message
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.DisplayMessage displayLastMassage)
        {
            ViewBag.DisplayMassage = displayLastMassage.DisplayMassage;
            return View();
        }
    }
}
