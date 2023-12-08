using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerInMVC.Controllers
{
    public class HomeController : Controller
    {
        //// GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // action method -> any method inside a controller

        // Index() -> action method
        public string Index()
        {
            return "Hello World";
        }

        // Name() -> action method
        public string Name()
        {
            return "Shanu";
        }

    }
}