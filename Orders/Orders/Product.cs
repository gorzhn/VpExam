using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Product
    {
        public string ime { get; set; }
        public int cena { get; set; }

        public override string ToString()
        {
            return ime + "-" +  cena;
        }
        public Product(string ime, int cena) {

            this.ime = ime;
            this.cena = cena;
        }
    }
}
