using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class ArithmeticOperation : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Arithmetic model, string displayValue)
        {
            if (displayValue == "+")
            {
                model.DisplayResult = model.FirstValue + model.SecondValue;
            }
            else if (displayValue == "-")
            {
                model.DisplayResult = model.FirstValue - model.SecondValue;
            }
            else if (displayValue == "*")
            {
                model.DisplayResult = model.FirstValue * model.SecondValue;
            }
            else if (displayValue == "/")
            {
                model.DisplayResult = model.FirstValue / model.SecondValue;
            }
            return View(model);
        }
    }
}
