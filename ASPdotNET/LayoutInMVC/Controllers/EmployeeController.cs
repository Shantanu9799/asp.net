using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("NewEmployee")]
        public ActionResult AddEmployee()
        {
            return View("AddEmployee", "_Layout"); // view, Layout
        }
        [Route("EmployeeList")]
        public ActionResult GetList()
        {
            return View("GetList", "_Layout");  // view, Layout
        }

    }
}