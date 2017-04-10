using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Asiento
    {
        public string NumSerie {get; set;}
        
        private Cinturon _cinturon;
        public Asiento() { }
        public Asiento(Cinturon cinturon) {
            _cinturon = cinturon;            
        }
        public Cinturon cinturon { get {return _cinturon;} }
    }
}
