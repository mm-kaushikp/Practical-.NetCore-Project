using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class datePicker
    {
        [Display(Name = "Event Date")]
        public DateTime Date { get; set; }
    }
}
