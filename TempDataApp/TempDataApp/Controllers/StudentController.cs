using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataApp.Models;

namespace TempDataApp.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Profile(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProfile(Student student)
        {
            return View();
        }

        [HttpPut]
        public ActionResult UpdateProfile(int id,Student student)
        {
            return View();
        }

        [HttpDelete]
        public ActionResult DeleteProfile(int id,Student student)
        {
            return View();
        }
    }
}