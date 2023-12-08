using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;
using MyApp.Db.DbOperations;

namespace EntityFrameworkInMVC.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository = null;

        public HomeController()
        {
            repository = new EmployeeRepository();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int id = repository.AddEmployee(model);
                if(id > 0)
                {
                    ModelState.Clear();
                    ViewBag.issuccess = "Data Added Successfully !!!";
                }
            }
            return View();
        }

        public ActionResult GetAllRecords()
        {
            var result = repository.GetAllEmployees();
            return View(result);
        }
        public ActionResult Details(int id)
        {
            var result = repository.GetEmployee(id);
            return View(result);
        }
        public ActionResult Edit(int id)
        {
            var result = repository.GetEmployee(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                repository.UpdateEmployee(model.ID, model);
                return RedirectToAction("GetAllRecords");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository.DeleteEmployee(id);
            return RedirectToAction("GetAllRecords");
            //return View("GetAllRecords");
        }
    }
}