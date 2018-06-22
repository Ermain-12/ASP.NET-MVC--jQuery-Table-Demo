using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDataCenter.Models;

namespace EmployeeDataCenter.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            using(EmployeeTableModel db = new EmployeeTableModel())
            {
                var empList = db.Employees.ToList();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}