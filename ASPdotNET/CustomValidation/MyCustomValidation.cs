using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation
{
    public class MyCustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string message = value.ToString();
                if(message.Contains("Shantanu") || message.Contains("shantanu"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? "Message should contains the word - Shantanu or shantanu";
            return new ValidationResult(ErrorMessage);
        }
    }
}