using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Helloword : Controller
    {
        // GET: Helloword
        public ActionResult Index()
        {
            ViewBag.message = "Hello World...!!";
            ViewBag.currentdatetime = DateTime.Now.ToString();
            return View();
        }
    }
}
