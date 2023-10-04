using System.Web.Mvc;
using PassDataFromViewToController.Models;

namespace PassDataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //Post using parameters
        [HttpPost]
        public string PostUsingParameters(string firstName,string lastName)
        {
            return " From Parameter " + firstName + " " + lastName;
        }

        //Post using request
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];

            return firstName + " " + lastName;
        }

        //Post using form collection
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return firstName + " " + lastName;
        }

        //Post using strongly binding
        [HttpPost]
        public string PostUsingBinding(Employee emp)
        {
            return " From Binding " + emp.firstName + " " + emp.lastName;
        }
    }
}