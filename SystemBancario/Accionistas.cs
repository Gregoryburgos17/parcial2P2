using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemBancario
{
    class Accionistas : IDivisasUSA
    {
        public void Actualizar()
        {
            if (DivisasUSA.Acciones < 58)
            {
                Thread.Sleep(5000);//Espera 3 sg
                double dolaractual =58.30;
                Console.WriteLine("Las acciones estan SUBIENDO...");
                Console.WriteLine($"vendiendo acciones {dolaractual}%");
            }
        }
    }
}
