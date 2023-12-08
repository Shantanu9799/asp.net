using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingTraditionalWay
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            

            ///* Custom Routes */
            //routes.MapRoute(
            //    name: "allstudents",
            //    url: "students",
            //    defaults: new { controller = "Student", action = "GetAllStudents" }
            //);

            //routes.MapRoute(
            //    name: "singlestudent",
            //    url: "student/{id}",
            //    defaults: new { controller = "Student", action = "GetStudent" }
            //);

            //routes.MapRoute(
            //    name: "studentaddress",
            //    url: "student/{id}/address",
            //    defaults: new { controller = "Student", action = "GetStudentAddress" }
            //);

          

            /* Default Route */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
