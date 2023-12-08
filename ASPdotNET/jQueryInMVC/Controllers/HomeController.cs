using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQueryInMVC.Models;
using Newtonsoft.Json;

namespace jQueryInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Shantanu Chatterjee",
                Email = "cshantanu712@gmail.com"
            };

            var json = JsonConvert.SerializeObject(student);

            return Json(json, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddStudent()
        {

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}