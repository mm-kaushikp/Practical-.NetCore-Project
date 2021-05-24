using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegistrationValidation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(registrationValidation model, string btnClick)
        {
            if (ModelState.IsValid && btnClick == "Submit")
            {
                registrationValidation objResult = new registrationValidation();
                objResult.FirstName = model.FirstName;
                objResult.LastName = model.LastName;
                objResult.Age = model.Age;
                objResult.Password = model.Password;
                objResult.ConfirmPassword = model.ConfirmPassword;
                objResult.Email = model.Email;
                ViewBag.result = objResult;
            }
            else if (btnClick == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
