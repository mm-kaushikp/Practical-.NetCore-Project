using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DisplayMonth : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(displayMonth model, string btnclick)
        {
            if (btnclick == "Show Month")
            {
                string months = "January,February,March,April,May,Jun,July,Augast,September,Octomber,November,December";
                if (model.MonthNo == "1")
                {
                    ViewBag.Month = months.Split(',')[0];
                }
                else if (model.MonthNo == "2")
                { ViewBag.Month = months.Split(',')[1]; }
                else if (model.MonthNo == "3")
                { ViewBag.Month = months.Split(',')[2]; }
                else if (model.MonthNo == "4")
                { ViewBag.Month = months.Split(',')[3]; }
                else if (model.MonthNo == "5")
                { ViewBag.Month = months.Split(',')[4]; }
                else if (model.MonthNo == "6")
                { ViewBag.Month = months.Split(',')[5]; }
                else if (model.MonthNo == "7")
                { ViewBag.Month = months.Split(',')[6]; }
                else if (model.MonthNo == "8")
                { ViewBag.Month = months.Split(',')[7]; }
                else if (model.MonthNo == "9")
                { ViewBag.Month = months.Split(',')[8]; }
                else if (model.MonthNo == "10")
                { ViewBag.Month = months.Split(',')[9]; }
                else if (model.MonthNo == "11")
                { ViewBag.Month = months.Split(',')[10]; }
                else if (model.MonthNo == "12")
                { ViewBag.Month = months.Split(',')[11]; }
            }
            else if (btnclick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }

    }
}
