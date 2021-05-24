using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class compareValidation
    {
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Both Password Must be Same")]
        public string ConfirmPassword { get; set; }
    }
}
