using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
   public class Driver
    {
        public string ime { get; set; }
        public int age { get; set; }
        public bool prv { get; set; }
        public List<Lap> laps;


            public Driver() {
            laps = new List<Lap>();

        }
        public override string ToString()
        {
            return string.Format("{0}({1}) - {2}", ime, age, prv?"F":"S");
        }
    }
}
