using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("employeInformationTable")]
    public class employeInformation
    {
        [Key]
        public int EmployeId { get; set; }
        [Display(Name = "Employee Name")]
        public string EmloyeeName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Address { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
