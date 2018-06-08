using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Song
    {
        public string Name { get; set; }
        public float Rating { get; set; }
        public int Duration { get; set; }
        public Song() { }
        public Song(string name, float rating, int duration)
        {
            Name = name;
            Rating = rating;
            Duration = duration;
        }
        public override string ToString()
        {
            return string.Format(" {0} - {1} ", Name, Duration);
        }
    }
}
