using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeLists.Models
{
    public class ListModel
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Measure { get; set; }
        public bool Check { get; set; }
    }
}