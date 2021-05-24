using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("CustomerEntryTable")]
    public class customerEntery
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
