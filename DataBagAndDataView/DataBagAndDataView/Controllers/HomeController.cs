using DataBagAndDataView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataBagAndDataView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //view bag examples
            ViewBag.MyCustomProperty = "Muhammad Munib Khan";
            //Example with list
            ViewBag.MyList = new List<string>(){"Danial","Hamza","Luqman","Saad"};
        
            //Employee class model
            List<Employee> emplist = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Daud Khan",
                    Email = "abc@gmail.com"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Arbab Khan",
                    Email = "abc@gmail.com"
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Anwar Khan",
                    Email = "abc@gmail.com"
                },new Employee()
                {
                    Id = 4,
                    Name = "Hamza Khan",
                    Email = "abc@gmail.com"
                }
            };

            ViewBag.MyEmpList = emplist;

            return View();
        }

        public ActionResult Demo()
        {

            ViewData["MyKey"] = "This is the value for my key";
            ViewData["MyList"] = new List<string>() { "Danial", "Hamza", "Luqman", "Saad" };
            return View();
        }
    }
}