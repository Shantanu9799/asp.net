using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerInMVC.Controllers
{
    public class GameController : Controller
    {

        // Home Work - 1
        public string Name(string name)
        {
            return "Welcome to " + name;
        }


        // Home Work - 2
        public string FullName(string? firstname, string? lastname)
        {
            if(firstname!=null && lastname!=null)
            {
                return "Your First Name is " + firstname + " and Last Name is " + lastname;
            } 
            else if(firstname != null && lastname == null)
            {
                return "Your First Name is " + firstname;
            }
            else if(firstname == null && lastname != null)
            {
                return "Your Last Name is " + lastname;
            }
            return "";
        }


    }
}