using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationInMVC
{
    public class CustomValidationClass : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("munib"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field must contain munib";
            return new ValidationResult(ErrorMessage);
        }
    }
}