using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationLooselyBinding.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please enter your First Name here...")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name here...")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address...")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Your Age is not in Between 18 - 100. Please check your age correctly...")]
        [Range(18, 100)]
        public int Age { get; set; }
    }
}