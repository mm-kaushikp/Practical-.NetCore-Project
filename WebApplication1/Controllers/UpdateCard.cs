using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UpdateCard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String Card)
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult GetCardDetails(CardDetails model, string isDefaultPic)
        {
            model.IsDefaultPic = isDefaultPic == "true";
            return PartialView("~/Views/UpdateCard/_GetCardDetails.cshtml", model);
        }
    }
}
