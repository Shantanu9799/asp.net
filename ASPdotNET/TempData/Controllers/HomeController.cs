using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["myKey"] = "This is the Index data";
            TempData.Keep("myKey");
            return View();
        }

        public ActionResult Index2()
        {
            //ViewBag.MyKey = TempData["myKey"];
            //TempData.Keep("myKey");
            ViewBag.MyKey = TempData.Peek("myKey");
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.MyKey = TempData["myKey"];
            return View();
        }

    }
}