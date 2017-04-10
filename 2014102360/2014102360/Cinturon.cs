using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Cinturon
    {
        public string NumSerie { get; set; }
        public int Metraje { get; set; }

        public Cinturon() { }

        public Cinturon(string numSer, int met) {
            NumSerie = numSer;
            Metraje = met;
        }
    }
}
