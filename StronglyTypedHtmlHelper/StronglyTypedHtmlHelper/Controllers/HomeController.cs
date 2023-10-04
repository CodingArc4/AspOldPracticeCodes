using StronglyTypedHtmlHelper.Models;
using System.Web.Mvc;

namespace StronglyTypedHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee
            {
                Address = "This is my Address",
                isEmployee = true,
                Name = "ABC Name"
            };

            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
    }
}