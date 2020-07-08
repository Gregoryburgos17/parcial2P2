using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class App
    {

        private Prestamo presta;
        private Cuenta cuento;
        private Tarjeta tarje;
        private  readonly Certificado CER;
        public void OperacionessPrestamos()
        {
            Console.WriteLine("***SOLICITUD DE PRESTAMOvil***");
            Console.Write("Digite el monto:[#] ");
            double monto = double.Parse(Console.ReadLine());
            Console.Write("Digite la tasa:[%] ");
            double tasa = double.Parse(Console.ReadLine());
            presta = new Prestamo(monto, tasa);//Creando el objeto de tipo Prestamos
            presta.montodeP();
            Console.ReadKey();


        }



        public void OperacionesCuentas()
        {
            double balance;

            Console.Write("Digite su #829 de cuenta: ");
            int num = int.Parse(Console.ReadLine());
            cuento = new Cuenta(num);//Creo el objeto
            Console.WriteLine("[1]Deposito  [2]Retiro");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Diga el monto: ");
                double monto = double.Parse(Console.ReadLine());
                balance = cuento.Depositar(monto);//Accedo al metodo de la clase cuenta
                Console.Write($"Su balance es: {balance}");
                Console.ReadKey();
            }
            else
            {
                Console.Write(" el monto a retirar:");
                double monto = double.Parse(Console.ReadLine());
                balance = cuento.Retirar(monto);
                Console.Write($"Su balance es: {balance}");
                Console.ReadKey();
            }




        }
        public void OperacionesTarjetas()
        {
            double monto;

            Console.Write("Diga el # de la tarjeta: ");
            int nuum = int.Parse(Console.ReadLine());
            tarje = new Tarjeta(nuum);//Creamos el objeto tarjeta
            Console.Write("Cuanto va a pagar del prestamo: ");
            monto = double.Parse(Console.ReadLine());
            tarje.monto(monto);//Usamos la funcionalidad de la tarjeta

            Console.ReadKey();

        }
        public void OperacionesConsulta()
        {
            string cer;
            cer = cuento.consulta();
            Console.WriteLine(cer);
            Console.ReadKey();


        }
        public void Operacion()
        {

            CER.certificado();
            Console.ReadKey();

        }
    }
}
