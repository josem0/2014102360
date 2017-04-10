using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Propietario
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaConducir { get; set; }

        public Propietario() { }

        public Propietario(string dni, string nom, string ape, string lic) {
            DNI = dni;
            Nombres = nom;
            Apellidos = ape;
            LicenciaConducir = lic;
        }
    }
}
