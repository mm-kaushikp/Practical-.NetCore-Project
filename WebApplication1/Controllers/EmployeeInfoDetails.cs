using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using System;
using System.Linq;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    public class EmployeeInfoDetails : Controller
    {
        private LoginDbContext db = new LoginDbContext();

        // GET: Employee List
        public ActionResult Index(string employeeId = "", int? page = 1)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            var results = db.departmentReports.AsQueryable();
            return View(results.AsQueryable().OrderBy(x => x.DepartmentId).ToPagedList(pageNumber, pageSize));
        }


        [HttpGet]
        public PartialViewResult GetEmpDetails(string employeeId)
        {
            var result = db.departmentReports.Find(Convert.ToInt32(employeeId));
            return PartialView("~/Views/EmployeeInfoDetails/_EmployeeDetail.cshtml", result);
        }
    }
}