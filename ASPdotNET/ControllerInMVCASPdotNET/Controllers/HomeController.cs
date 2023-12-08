using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerInMVCASPdotNET.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public string Name()
        {
            return "Shantanu";
        }

    }
}