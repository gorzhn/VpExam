using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Album
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public List<Song> Songs { get; set; }

        public void AddSong(Song s) {
            Songs.Add(s);
        }

        public Song findSong(string name) {
            
                foreach (Song i in Songs)
                {
                    if (i.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return i;
                    }

                }
                throw new Exception(name);
            
           
        }
    
  
    
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append('\n');
            sb.Append(Year);
            sb.Append('\n');
            sb.Append("Songs:\n");
            int i = 1;
            foreach (Song song in Songs)
            {
                sb.Append(string.Format("{0}. ", i++));
                sb.Append(song);
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
