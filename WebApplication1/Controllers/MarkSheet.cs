using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MarkSheet : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MarksheetModel model, string btnClick)
        {
            if (btnClick == "Calculate")
            {
                ViewBag.Total = model.s1 + model.s2 + model.s3 + model.s4 + model.s5;
                ViewBag.per = Convert.ToInt32(ViewBag.Total) / 5.0;
                if (Convert.ToInt32(ViewBag.per) >= 60)
                {
                    ViewBag.Grad = "First";
                }
                else if (Convert.ToInt32(ViewBag.per) < 60 && Convert.ToInt32(ViewBag.per) >= 48)
                {
                    ViewBag.Grad = "Second";
                }
                else if (Convert.ToInt32(ViewBag.per) < 48 && Convert.ToInt32(ViewBag.per) >= 36)
                {
                    ViewBag.Grad = "Pass";
                }
                else
                {
                    ViewBag.Grad = "Fail";
                }
            }
            else if (btnClick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
