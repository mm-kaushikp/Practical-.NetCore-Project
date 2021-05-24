using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class rangeValidation
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "Enter Age between 18 to 30")]
        [Range(18, 30)]
        public int Age { get; set; }
    }
}
