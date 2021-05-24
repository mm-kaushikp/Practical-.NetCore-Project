using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("ClientMasterTable")]
    public class clientMaster
    {
        [Key]
        public int ClientId { get; set;  }
        [Display(Name = "Client Number")]
        public string ClientNumber { get; set;  }
        [Display(Name = "Client Name")]
        public string ClientName { get; set;  }
        public string Address { get; set;  }
        public string City { get; set;  }
        public string State { get; set;  }
        public string PinCode { get; set;  }

    }
}
