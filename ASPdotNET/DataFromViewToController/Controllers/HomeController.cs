using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFromViewToController.Models;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // 1st method
        [HttpPost]
        public string PostUsingParameters(string firstName, string lastName)
        {
            return "BY PARAMETERS -First Name = " + firstName + "Last Name = " + lastName;
        }

        // 2nd method
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "BY REQUESTING - First Name = " + firstName + "Last Name = " + lastName;
        }

        // 3rd method
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "BY FORM COLLECTION - First Name = " + firstName + "Last Name = " + lastName;
        }

        [HttpPost]
        public string PostUsingStronglyBinding(Employee employee)
        {
            string firstName = employee.firstName;
            string lastName = employee.firstName;
            return "BY STRONGLY BINDING - First Name = " + firstName + "Last Name = " + lastName;
        }

    }
}