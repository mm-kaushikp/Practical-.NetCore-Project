using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegistrationForm : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(registrationForm model, string btnclick)
        {
            if (btnclick == "Register")
            {
                registrationForm objRegistration = new registrationForm();
                objRegistration.FirstName = model.FirstName;
                objRegistration.LastName = model.LastName;
                objRegistration.BirthDate = model.BirthDate;
                objRegistration.Address = model.Address;
                objRegistration.Zipcode = model.Zipcode;
                objRegistration.Country = model.Country;
                ViewBag.result = objRegistration;
            }
           else if (btnclick == "Reset")
            {
                ModelState.Clear();
            }

            return View();
        }
    }
}
