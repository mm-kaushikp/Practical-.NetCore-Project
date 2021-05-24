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
        public string Eno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public string HireDate { get; set; }
        public string Salary { get; set; }
        public string Commition { get; set; }
        public string DepartmentName { get; set; }
    }
}
