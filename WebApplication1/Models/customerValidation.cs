using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class customerValidation
    {
        [StringLength(10, ErrorMessage = "Comment must be less than 10 characters!")]
        public string comment { get; set; }
    }
}
