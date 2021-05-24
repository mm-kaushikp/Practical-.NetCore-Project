using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CardDetails
    {
        public string BackgroundColor { get; set; }
        public string Font { get; set; }
        public int FontSize { get; set; }
        public string BorderStyle { get; set; }
        public bool IsDefaultPic { get; set; }
        public string GreetingText { get; set; }
    }
}
