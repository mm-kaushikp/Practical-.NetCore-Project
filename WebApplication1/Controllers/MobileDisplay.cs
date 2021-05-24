using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1.Controllers
{
    public class MobileDisplay : Controller
    {
        private LoginDbContext db = new LoginDbContext();
        private IHostingEnvironment _env;

        public MobileDisplay(IHostingEnvironment env)
        {
            _env = env;
        }
        // GET: Mobile Display
        public ActionResult Index()
        {
            return View(db.mobileDisplays.ToList());
        }

        // GET:  Mobile Display/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST:  Mobile Display/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mobileDisplay model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".PNG", ".JPEG" };
                mobileDisplay mobileData = new mobileDisplay();
                mobileData.ModelName = model.ModelName;
                mobileData.Price = model.Price;
                var fileName = Path.GetFileName(file.FileName);
                var fileExtension = Path.GetExtension(file.FileName);
                if (allowedExtensions.Contains(fileExtension)) 
                {
                    string name = Path.GetFileNameWithoutExtension(fileName);   
                    string myfile = name + fileExtension;
                    var path = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(path, myfile);
                    mobileData.FileName = myfile;
                    db.mobileDisplays.Add(mobileData);
                    db.SaveChanges();
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.message = "Please choose only Image file";
                }

            }

            return View(model);
        }
    }
}