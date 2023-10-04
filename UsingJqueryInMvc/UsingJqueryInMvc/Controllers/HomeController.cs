using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingJqueryInMvc.Models;
using Newtonsoft.Json;

namespace UsingJqueryInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                Id = 1,
                Email = "abc@yahoo.com",
                Name = "Jason"
            };

            var json = JsonConvert.SerializeObject(std);

            return Json(json,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddStudent(Student student)
        {
            return Json("True", JsonRequestBehavior.AllowGet);
        }
    }
}