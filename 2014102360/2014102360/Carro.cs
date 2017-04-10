using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Carro
    {
        private Volante _volante;
        private Parabrisas _parabrisas;
        private int _numLlantas;
        private int _numAsientos;
        private Propietario _propietario;
        private TipoCarro _tipoCarro;
        private Llanta _llanta;
        private Asiento _asiento;

    public string NumSerieMotor { get; set; }
    public string NumSerieChasis { get; set; }
    public Carro (){
        _llanta = new Llanta();
        _asiento = new Asiento();
    }
    public Carro(Volante volante, Parabrisas parabrisas,
            Propietario propietario, TipoCarro tipoCarro)
    {
        _volante = volante;
        _parabrisas = parabrisas;
        _propietario = propietario;
        _tipoCarro = tipoCarro;
            AsientosyLLantas();
        }
        public void AsientosyLLantas() {
            if (_tipoCarro == TipoCarro.Automovil)
            {
                _numAsientos = 5;
                _numLlantas = 4;
            }
            else {
                _numLlantas = 6;
                _numAsientos = 10;
            }
            Console.WriteLine("NumLlantas: " + _numLlantas);
            Console.WriteLine("NumAsientos: " + _numAsientos);
  
      

        }

        public Volante volante { get {return _volante;}}
        public Parabrisas parabrisas { get { return _parabrisas; } }
        public Propietario propietario { get { return _propietario; } }
        public Asiento asiento { get { return _asiento; } }
        public Llanta llanta { get { return _llanta; } }
    }
}
