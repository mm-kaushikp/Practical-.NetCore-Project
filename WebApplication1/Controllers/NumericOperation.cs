using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class NumericOperation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string DisplayValue, string NumericValue)
        {
            if (NumericValue == "oddeven")
            {
                ViewBag.DisplayValue = Convert.ToInt32(DisplayValue) % 2 == 0 ? "Number is Even" : "Number is Odd";
            }
            else if (NumericValue == "positivnagative")
            {
                if (Convert.ToInt32(DisplayValue) > 0)
                {
                    ViewBag.DisplayValue = "Number is Positive";
                }
                else if (Convert.ToInt32(DisplayValue) < 0)
                {

                    ViewBag.DisplayValue = "Number is Negative";
                }
            }
            else if (NumericValue == "square")
            {
                ViewBag.DisplayValue = (Math.Sqrt(Convert.ToInt32(DisplayValue))) % 1 == 0 ? "Square Number " : "Not a Square Number";
            }
            else if (NumericValue == "factorial")
            {
                var fact = 1;
                for (int i = 1; i <= Convert.ToInt32(DisplayValue); i++)
                {
                    fact = fact * i;
                }
                ViewBag.DisplayValue = fact;
            }
            return View();
        }

    }
}
