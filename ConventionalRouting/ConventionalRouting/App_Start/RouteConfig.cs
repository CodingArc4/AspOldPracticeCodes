using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConventionalRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //Custom Routes
 //           routes.MapRoute(
 //               name: "allstudents",
 //             url: "students",
 //               defaults: new {Controller = "Student",action = "GetAllStudent"} 
 //           );

 //           routes.MapRoute(
 //              name: "student",
 //              url: "students/{id}",
 //              defaults: new { Controller = "Student", action = "GetStudent" }
 //          );

 //           routes.MapRoute(
 //                name: "address",
 //                url: "students/{id}/address",
 //                defaults: new { Controller = "Student", action = "GetStudentAddress" },
 //                constraints: new { id = @"\d+" }
 //          );
 
            //Default Route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}