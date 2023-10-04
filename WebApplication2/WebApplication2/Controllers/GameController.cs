using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class GameController : Controller
    {
        public string Name()
        {
            return "Hello from GameContorller";
        }

        public string FullName(string first,string last)
        {
            return "First Name = " + first + " Last Name = " + last;
        }
    }
}