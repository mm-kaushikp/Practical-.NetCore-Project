using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentReport : Controller
    {
        private LoginDbContext db = new LoginDbContext();

        // GET: Department
        public async Task<ActionResult> Index(string depName = "")
        {
            var result = new List<departmentReport>();
            ViewBag.DeprtmentList = db.departmentReports.Select(g => g.DepartmentName).Distinct().ToList();
            if (string.IsNullOrEmpty(depName))
            {
                result = db.departmentReports.Where(x => x.DepartmentName.Trim().ToUpper().Contains(depName.Trim().ToUpper())).ToList();
            }
            else
            {
                result = db.departmentReports.Where(x => x.DepartmentName.Trim().ToUpper().Contains(depName.Trim().ToUpper())).ToList();
            }
            if (result.Count == 0)
            {
                return View(await db.departmentReports.ToListAsync());
            }
            else
            {
                return View(result);
            }
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(departmentReport model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.departmentReports.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator");
            }
            return View(model);
        }
    }
}
