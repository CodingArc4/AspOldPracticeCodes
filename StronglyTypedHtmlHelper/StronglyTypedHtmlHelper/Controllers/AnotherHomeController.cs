using TemplatedHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace StronglyTypedHtmlHelper.Controllers
{
    public class AnotherHomeController : Controller
    {
        // GET: AnotherHome
        public ActionResult Index()
        {

            AnotherEmployee aemp = new AnotherEmployee()
            {

            };
            

            return View();
        }
    }
}