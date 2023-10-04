using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EntityFrameworkInMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.MapRoute(
            //   name: "Delete",
            // url:"employee/Delete/{id}",
            // defaults: new {Controller = "Home", Action="Delete"}
            // );

            //routes.MapRoute(
              //  name: "ListAllEmployees",
                //url: "LsitEmp",
                //defaults: new {Controller = "Home",Action = "GetAllRecords"}
                //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "GetAllRecords", id = UrlParameter.Optional }
            );
        }
    }
}
