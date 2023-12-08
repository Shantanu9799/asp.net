using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxForm.Models;

namespace AjaxForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Employee emp)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}