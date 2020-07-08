using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class Tarjeta
    {
        public int TarjetaS;
        public Tarjeta(int num)
        {
            TarjetaS = num;

        }

        public void monto(double pago)
        {
            Console.WriteLine($"La tarjeta #{TarjetaS} Tiene un balance de  {pago}");
        }

       
    }
}
