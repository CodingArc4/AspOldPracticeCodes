using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from planet earth";
        }

        public string Name()
        {
            return "My name is hello world";
        }
    }
}