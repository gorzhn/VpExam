using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Product
    {
        public int kod { get; set; }
        public string ime { get; set; }
        public int cena { get; set; }
        public override string ToString()
        {
            return ime;
        }
    }
}
