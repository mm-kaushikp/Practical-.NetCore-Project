using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class registrationValidation
    {
        [Required(ErrorMessage = "First Name Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age Required!")]
        [Range(10, 20, ErrorMessage = "Please Enter Age Between 10 And 20!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Password  Required!")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Both Password Must be Same")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email Required!")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email Address!!")]
        public string Email { get; set; }
    }
}
