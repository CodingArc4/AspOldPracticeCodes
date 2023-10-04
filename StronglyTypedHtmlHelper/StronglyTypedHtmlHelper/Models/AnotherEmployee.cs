using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedHtmlHelper.Models
{
    public class AnotherEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public  string Email { get; set; }

        public bool isEmployee { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}