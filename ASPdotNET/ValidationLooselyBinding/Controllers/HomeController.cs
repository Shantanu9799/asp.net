using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationLooselyBinding.Models;

namespace ValidationLooselyBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SubmitData(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }
    }
}