using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsInMVC.Models;

namespace ModelsInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            var data = GetEmployee(); //--> Get data from the GetEmployee() function
            return View(data); //--> pass the data var in the view to show it in the frontend
        }

        private Employee GetEmployee()
        {
            return new Employee() {

                Id = 1,
                Address = "Abc city",
                Name = "WebGentle"

            };
        }

    }
}