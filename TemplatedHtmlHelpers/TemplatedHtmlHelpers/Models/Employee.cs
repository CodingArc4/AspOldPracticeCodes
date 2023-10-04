using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TemplatedHtmlHelpers.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Display(Name="Plz enter your name")]
        public string Name { get; set; }

        public string Email { get; set; }

        public bool isEmployee { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}