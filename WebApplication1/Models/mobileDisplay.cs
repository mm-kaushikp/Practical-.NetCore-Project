using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("DisplayMobileTable")]
    public class mobileDisplay
    {
        [Key]
        public int MobileId { get; set; }
        public string ModelName { get; set; }
        public string Price { get; set; }
        public string FileName { get; set; }
    }
}
