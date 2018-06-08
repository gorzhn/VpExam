using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
   public class Student
    {
        public List<Courses> courses{ get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public int indeks { get; set; }


        public Student() {
            courses = new List<Courses>();
        }
        public override string ToString()
        {
            return string.Format( "{0}  {1} : {2}",ime,prezime,indeks);
        }

    }
}
