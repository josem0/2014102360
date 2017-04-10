using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360
{
    public class Program
    {
        static void Main(string[] args)
        { string numChasis;
            Volante vol1 = new Volante("VOLANTE1");
            Parabrisas par1 = new Parabrisas("PARABRISAS1");
            Propietario pers1 = new Propietario("12345678", "Luis", "Espinoza", "PLACA1");
            numChasis = "CHASIS1";

            var a = new Ensambladora();
            var c = new Carro();

            Carro carro1 = new Carro(vol1, par1, pers1, TipoCarro.Automovil);

            a.Agregar(carro1, numChasis);
            a.FinalizarPersonalizacion(numChasis);

            Volante vol2 = new Volante("VOLANTE2");
            numChasis = "CHASIS2";
            Parabrisas par2 = new Parabrisas("PARABRISAS2");
            Propietario pers2 = new Propietario("11223344", "Ernesto", "Cotrina", "PLACA2");
            Carro carro2 = new Carro(vol2, par2, pers2, TipoCarro.Automovil);
           a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro2, numChasis);
            a.FinalizarPersonalizacion(numChasis);

            Volante vol3 = new Volante("VOLANTE2");
            Parabrisas par3 = new Parabrisas("PARABRISAS3");
            numChasis = "CHASIS3";
            Propietario pers3 = new Propietario("88776655", "Daria", "Suarez", "PLACA3");
            Carro carro3 = new Carro(vol1, par1, pers1, TipoCarro.Automovil);
           a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro3, numChasis);
            a.FinalizarPersonalizacion(numChasis);

   
            
        }
    }
}
