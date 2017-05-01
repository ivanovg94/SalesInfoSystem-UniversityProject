using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4_2
{
     public class Item
    {
       

        public string name { get; set; }
        public double? unitPrice { get; set; }
        public string currency { get; set; }

        

        public Item(string name, double? unitPrice, string currency)
        {
            this.name = name;
            this.unitPrice = unitPrice;
            this.currency = currency;
        }
    }
}
