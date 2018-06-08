using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosnica1
{
    public class Product
    {
        public int Cena { get; set; }
        public string Ime { get; set; }
        public string Kategorija { get; set; }


        public Product() {
            this.Cena = Cena;
            this.Ime = Ime;
            this.Kategorija = Kategorija;
        }

        public override string ToString()
        {
            return Ime.ToString() ;
        }
    }
}
