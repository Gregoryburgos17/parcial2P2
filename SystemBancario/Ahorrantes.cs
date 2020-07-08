using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class Ahorrantes : IDivisasUSA
    {
        public void Actualizar()
        {
            if (DivisasUSA.Acciones >= 53)
            {
                double dolaractual = 58.30;
                double multi = 4;
                double menos = 100;
                double ine = dolaractual * multi;
                double holaprofesor = ine - menos;
                Console.WriteLine("Las acciones estan BAJANDO!!!");
                Console.WriteLine($"comprando dolares  {holaprofesor} \n");
            }
        }
    }
}
