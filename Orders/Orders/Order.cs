using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
   public class Order
    {
        public Product product{ get; set; }
        public int kolicina { get; set; }
        public string zabeleska { get; set; }
        public int vkupno;
        public decimal Total
        {
            get
            {
                return product.cena * kolicina;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} x {1} = {2} ден", kolicina, product.ime, Total);
        }
    }
}
