using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class reqiredValidation
    {
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }
    }
}
