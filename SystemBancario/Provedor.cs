using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class Provedor
    {
        private static Provedor atributo;

        public double numero;
        public string usuario;
        public string gmail;

        private Provedor(double n,string u,string g)
        {
            numero = n;
            usuario = u;
            gmail = g;
        }

        public static Provedor EstablecerTelefono(double num, string u, string g)
        {
            if (atributo == null)
            {
                atributo = new Provedor(num,u,g);
                return atributo;
            }
            return atributo;
        }

        public void Mostrar()
        {
            Console.WriteLine($"El  Accionistas {usuario} SU CEDULA  ES {numero} su gmail {gmail}");
        }

    }
}
