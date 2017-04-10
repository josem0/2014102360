using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class bus : Carro
    {
        public TipoBus _tipoBus { get; set;}
        private int _numAsientos { get; set; }
        private Volante _volante;
        private Parabrisas _parabrisas;
        private Propietario _propietario;
        private string _numSerieChasis;
        private TipoCarro _tipoCarro;

        public bus() { }
        public bus(Volante volante, Parabrisas parabrisas,
            Propietario propietario, TipoCarro tipoCarro, 
            TipoBus tipoBus, string numSerieChasis) {
            _volante = volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
            _numSerieChasis = numSerieChasis;
            _tipoCarro = tipoCarro;
        }
    }
}
