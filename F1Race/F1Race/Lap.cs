using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
   public class Lap
    {
        public int minuti { get; set; }
        public int sekundi { get; set; }


        public Lap(int minuti, int sekundi) {
            this.minuti = minuti;
            this.sekundi = sekundi;

        }

        public override string ToString()
        {
            return minuti + ":" + sekundi;
        }

    }
}
