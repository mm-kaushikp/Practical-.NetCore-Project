using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MarksheetModel
    {
        public string RollNo { get; set; }
        public string Name { get; set; }
        public double s1 { get; set; }
        public double s2 { get; set; }
        public double s3 { get; set; }
        public double s4 { get; set; }
        public double s5 { get; set; }
        public double Total { get; set; }
        public double Persantage { get; set; }
        public double Grade { get; set; }
    }
}
