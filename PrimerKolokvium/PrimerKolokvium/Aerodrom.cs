using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerKolokvium
{
   public class Aerodrom
    {
        public string ime { get; set; }
        public string grad { get; set; }
        public string kratenka { get; set; }
        public List<Destinacija> destinacii { get; set; }

        public Aerodrom(string i, string g, string k) {
            ime = i;
            grad = g;
            kratenka = k;
            destinacii = new List<Destinacija>();
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", kratenka, ime, grad);
        }
    }
}
