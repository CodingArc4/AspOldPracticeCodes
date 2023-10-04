using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxHelpersInMvc.Models;
using Newtonsoft.Json;

namespace AjaxHelpersInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Employee model)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {

            return View();
        }

        public JsonResult Countries()
        {
            List<string> countries = new List<string>(){
                 "Country -- ALgeria",
                 "Country -- Angola",
                 "Country -- Andorra",
                 "Country -- Albania",
                 "Country -- Bosnia",
                 "Country -- Coratia",
                 "Country -- Canada",
                 "Country -- czech republic",
                 "Country -- Japan",
                 "Country -- Korea",
                 "Country -- India",
                 "Country -- Qatar",
                 "Country -- Malaysia"
            };

            var json = JsonConvert.SerializeObject(countries);
            return Json(json,JsonRequestBehavior.AllowGet);
        }

        public JsonResult States()
        {
            List<string> States = new List<string>() {
                  "State -- California",
                  "State -- Texas",
                  "State -- New York",
                  "State -- Alberta",
                  "State -- Alaska",
                  "State -- British Columbia",
                  "State -- Washington",
                  "State -- Ohio",
                  "State -- Ontario",
                  "State -- Nova Scotia",
                  "State -- New Burnswick",
                  "State -- Northwestern Territories"
            };
            var json = JsonConvert.SerializeObject(States);
            return Json(json,JsonRequestBehavior.AllowGet);
        }

        public JsonResult City()
        {
            List<string> City = new List<string>() {
                   "City -- Edmonton",
                   "City -- New York City",
                   "City -- Washington DC",
                   "City -- London",
                   "City -- Zagreb",
                   "City -- Sarajevo",
                   "City -- Bucharest",
                   "City -- Kiyv",
                   "City -- Pripyat",
                   "City -- Sofia",
                   "City -- Dublin",
                   "City -- Belfast"
            };
            var json = JsonConvert.SerializeObject(City);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}