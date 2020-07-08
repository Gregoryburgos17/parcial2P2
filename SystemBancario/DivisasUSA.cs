using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class DivisasUSA
    {

        public static int Acciones { get; set; }//El atributo que definira el estado


        public List<IDivisasUSA> brokers = new List<IDivisasUSA>();

        public void AgregarSub(IDivisasUSA observador)
        {
            brokers.Add(observador);

        }

        public void QuitarSub(IDivisasUSA observador)
        {
            brokers.Remove(observador);

        }

        public void Notificar()
        {

            foreach (var elemento in brokers)
            {
                elemento.Actualizar();
            }
        }

        public void Operaciones(int opcion)
        {
            Acciones = opcion;
            Notificar();


        }
    }
}
