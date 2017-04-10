using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Automovil : Carro
    {
        public TipoAuto TipoAuto { get; set; }
        private Volante _volante;
        private Parabrisas _parabrisas;
        private int _numLlantas;
        private int _numAsientos;
        private string _numSerieChasis;
        private Propietario _propietario;
        private TipoCarro _tipoCarro;

        public Automovil() { }

        public Automovil(Volante volante, Parabrisas parabrisas,
            Propietario propietario, TipoCarro tipoCarro, 
            TipoAuto tipoAuto, string numSerieChasis)
        {
            _volante = volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
            _numSerieChasis = numSerieChasis;
            _tipoCarro = tipoCarro;
        }

        }
    
}
