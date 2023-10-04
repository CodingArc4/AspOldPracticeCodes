using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmployeeProfile(int id)

        {
            string profile = string.Empty;

            if (id == 1)
            {
                profile = "Employee 1 Profile";
            }
            else if (id == 2)
            {
                profile = "Employee 2 Profile";
            }
            else
            {
                profile = "No record Found";
            }

            return profile;

        }
        
        public string Address(int id,string Department)
        {
            return "id = " + id + " department = " + Department;
        }
    }
}