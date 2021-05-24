using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ImageSelection : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string imageSelect)
        {
            if (imageSelect == "blueHilles")
            {
                ViewBag.Logo = @"\Images\bluehills.jpg";
            }
            else if (imageSelect == "sunset")
            {
                ViewBag.Logo = @"\Images\sunset.jpg";

            }
            else if (imageSelect == "waterlilies")
            {
                ViewBag.Logo = @"\Images\Water.jpg";
            }
            else if (imageSelect == "winter")
            {
                ViewBag.Logo = @"\Images\water.jpg";
            }
            return View();
        }
    }
}
