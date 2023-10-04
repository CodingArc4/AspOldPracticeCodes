using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationInMvcInLooslyBinding.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Plz enter your first name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Plz enter your last name")]
        public string lastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Plz enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}