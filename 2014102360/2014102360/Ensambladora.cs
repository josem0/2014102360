using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Ensambladora
    {   private string tipo;
        private string a;
        private List<TipoAuto> _ta;
        private List<TipoBus> _tb;
        private List<TipoCarro> _tc;
        private List<Carro> _carro;
        private Carro car;
        private int _numLlantas;
        private int _numAsientos;

        public Ensambladora(){
         _carro = new List<Carro>();
            _ta = new List<TipoAuto>();
            car = new Carro();
        }
        public void Agregar(Carro carro, string numero) {
            if (numero[0] == 'a')
            {
                if (numero[1] == 's')
                {
                    _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.Sedan, numero));
                    Console.WriteLine("Es un: Sedan");
                }
                else {
                    if (numero[1] == 'p')
                    {
                        _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                        TipoAuto.PickUp, numero));
                        Console.WriteLine("Es un: PickUp");
                    }
                    else {
                        if (numero[1] == 'c')
                        {
                            _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                            TipoAuto.Coupe, numero));
                            Console.WriteLine("Es un: Coupe");
                        }
                        else {
                            if (numero[1] == 'h')
                            {
                                _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                TipoAuto.HatchBack, numero));
                                Console.WriteLine("Es un: HatchBack");
                            }
                            else {
_carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.NoDefinido, numero));
                                Console.WriteLine("Es un: No definido");
                            }
                        }
                    }
                }
                
            }
            else {
                
                if (numero[1] == '1') {
                    _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.Publico, numero));
                    Console.WriteLine("Es un: Bus Público");
                }
                else {
                    if (numero[1] == '2')
                    {
                        _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                            TipoBus.Privado, numero));
                        Console.WriteLine("Es un: Bus privado");
                    }
                    else {
                        _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.NoDefinido, numero));
                        Console.WriteLine("Es un: Bus no definido");
                    }
                }
            }
           
            }

            
       public void Eliminar(Carro carro, string numero) {
            Carro car = new Carro();
            Carro carrito = _carro.Find(c => c.NumSerieChasis == numero);
            if (numero[0] == 'a')
            {
                if (numero[1] == 's')
                {
                    _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.Sedan, numero));

                }
                else
                {
                    if (numero[1] == 'p')
                    {
                        _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                        TipoAuto.PickUp, numero));
                    }
                    else
                    {
                        if (numero[1] == 'c')
                        {
                            _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                            TipoAuto.Coupe, numero));
                        }
                        else
                        {
                            if (numero[1] == 'h')
                            {
                                _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                TipoAuto.HatchBack, numero));
                            }
                            else
                            {
                                _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                                    TipoAuto.NoDefinido, numero));
                            }
                        }
                    }
                }

            }
            else
            {

                if (numero[1] == '1')
                {
                    _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.Publico, numero));
                }
                else
                {
                    if (numero[1] == '2')
                    {
                        _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                            TipoBus.Privado, numero));
                    }
                    else
                    {
                        _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.NoDefinido, numero));
                    }
                }
            }
        }
        public void IniciarPersonalizacion(string numero) {
            Carro c = new Carro();
            c.NumSerieChasis = numero;
                }
        public void FinalizarPersonalizacion(string numero)
        {
            Carro carrito = _carro.Find(ca => ca.NumSerieChasis == numero);
            var c = new Carro().NumSerieChasis;
            string _a = c;
            Console.WriteLine("Numero de Serie de Chasis: {0}\n " ,numero);
            Console.ReadKey();

        }
        public void EnsamblarCarro()
        {
            
        }

    }   
    }

       
       

        
    

