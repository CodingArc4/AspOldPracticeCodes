using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHtmlHelpers.Models;

namespace TemplatedHtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee() {

                Id = 1,
                Name = "ABc",
                Email = "abc@gmail.com",
                DateOfBirth = DateTime.Now,
                isEmployee = true
            };

            return View(emp);
        }

        public ActionResult Edit()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
    }
}