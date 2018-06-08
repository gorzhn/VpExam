using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePapers
{
    public class Konferencija
    {
      
        public string ime { get; set; }
        public int godina { get; set; }

      
        public override string ToString()
        {
            return ime;
        }

    }
}
