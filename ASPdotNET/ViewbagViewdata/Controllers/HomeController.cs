using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewbagViewdata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewBag.myCustomProp = "Shantanu Chatterjee";
            ViewBag.myList = new List<string> { "c++", "Java", "JavaScript" };

            return View();
        }

        public ActionResult Demo()
        {

            ViewData["myName"] = "Shantanu Chatterjee";
            ViewData["myList"] = new List<string> { "c++", "Java", "JavaScript" };

            return View();
        }

    }
}