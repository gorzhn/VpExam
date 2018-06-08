using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerKolokvium
{
    public class Destinacija
    {
      public string ime { get; set; }
      public int dolzina { get; set; }
      public int cena { get; set; }

        public Destinacija(string i, int d, int c) {
            ime = i;
            dolzina = d;
            cena = c;

        }
        public override string ToString()
        {
            return ime;
        }
    }
}
