using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataApp.Models;

namespace TempDataApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["MyData"] = "This is the data from the index method";
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.MyData = TempData.Peek("MyData");
            //TempData.Keep("MyData");
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.MyData = TempData["MyData"];                
            return View();
        }
    }
}