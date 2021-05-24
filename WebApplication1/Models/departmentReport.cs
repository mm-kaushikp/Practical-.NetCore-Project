using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("DepartmentReport")]
    public class departmentReport
    {
        [Key]
        public int DepartmentId { get; set; }
        [Display(Name = ("Employee Number"))]
        public string Eno { get; set; }
        [Display(Name = ("Employee Name"))]
        public string Ename { get; set; }
        public string Job { get; set; }
        [Display(Name = ("Hire Date"))]
        public string HireDate { get; set; }
        public string Salary { get; set; }
        public string Commition { get; set; }
        [Display(Name = ("Department Name"))]
        public string DepartmentName { get; set; }
    }
}
