using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Lecture
    {
        public string name { get; set; }
        public Personne professeur { get; set; }
        public List<string> salle { get; set; }
        public List<Student> students { get; set; }
    }
}
