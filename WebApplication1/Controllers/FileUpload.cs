using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FileUpload : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(fileUpload model, string btnClick)
        {
            {
                if (btnClick == "Submit")
                {
                    ViewBag.result = model.UploadFile + " - File is Uploaded Successfully!";
                }
                if (btnClick == "Reset")
                {
                    ModelState.Clear();
                }
                return View();
            }
        }
    }
}
