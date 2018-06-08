using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
   public class Item
    {
        public int quantity { get; set; }
        public List<Product> p = new List<Product>();
    }
}
