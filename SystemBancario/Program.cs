using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("*****BANK SYSTEM*********\n");
                Console.WriteLine("[1]Requerimiento\n[2]Requerimiento\n[3]Requerimiento\n[4]salir"
                    +"\n*************************");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: Achada(); break;
                    case 2: etre(); 
                        break;
                    case 3: pilar();
                        break;
                    default: break;





                }
            } while (op!=4);
            Proceso();
            
        }
        public static void Achada()
        {
            fachada Fachada = new fachada();//Creando el objeto de tipo fachada

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1]Cuentas\n[2]Prestamos\n[3]Tarjetas\n[4]Api movil\n[5]inf\n[6]atras");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Fachada.OperacionesCuentas();
                        break;
                    case 2:
                        Fachada.OperacionessPrestamos();
                        break;
                    case 3:
                        Fachada.OperacionesTarjetas();
                        break;
                    case 4: movil(); break;
                    case 5:Fachada.Operacion(); break;

                }
            } while (opcion != 6);
            
        }
        public  static void Proceso()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            string facade = "el patrón de diseño de fachada indica que debe proporcionar\n una interfaz unificada a un conjunto de interfaces en un subsistema.";
            string observer = "definir una dependencia de uno a muchos entre los objetos para que\n cuando un objeto cambie de estado, todos sus dependientes sean notificados y actualizados automáticamente";
            string singleton = "Necesitamos usar el patrón de diseño Singleton en C #\n cuando necesitamos asegurarnos de que solo se creará una instancia de una clase en particular y\n luego proporcionar acceso global simple a esa instancia para toda la aplicación.";
            Console.WriteLine($"proceso este programa se ultilizo\n #FACADE#\n{facade}\n #OBSERVER#\n{observer}\n #SINGLETON#\n{singleton}");
            Console.ReadKey();
        }
        public static void etre()
        {
            DivisasUSA bolsa = new DivisasUSA();

            Ahorrantes div = new Ahorrantes();
            Inversionistas div2 = new Inversionistas();
            Accionistas div3 = new Accionistas();

            bolsa.AgregarSub(div);
            bolsa.AgregarSub(div2);
            bolsa.AgregarSub(div3);


            bolsa.Operaciones(54);

            Console.ReadKey();

            bolsa.QuitarSub(div);

            bolsa.Operaciones(58);

            Console.ReadKey();
        }
        
        public static void pilar()
        {

            //DATOS LOCAL
            string op = "";
            double numeroTelefonico;
            string usi;
            string gm;
            Console.WriteLine("Agregar\n[1]Ahorrantes\n[2]Inversionistas\n[3]Accionistas\n[4]atras");
            op = Console.ReadLine();
            do
            {
                switch (op)
                {
                    case "1":
                        Console.WriteLine("cedula: ");
                        numeroTelefonico = double.Parse(Console.ReadLine());
                        Console.WriteLine("nombre: ");
                        usi = Console.ReadLine();
                        Console.WriteLine("gmail: ");
                        gm = Console.ReadLine();
                        Provedor tel1 = Provedor.EstablecerTelefono(numeroTelefonico, usi, gm);
                        tel1.Mostrar();
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("cedula: ");
                        numeroTelefonico = double.Parse(Console.ReadLine());
                        Console.WriteLine("nombre: ");
                        usi = Console.ReadLine();
                        Console.WriteLine("gmail: ");
                        gm = Console.ReadLine();
                        Provedor tel2 = Provedor.EstablecerTelefono(numeroTelefonico, usi, gm);
                        tel2.Mostrar();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("cedula: ");
                        numeroTelefonico = double.Parse(Console.ReadLine());
                        Console.WriteLine("nombre: ");
                        usi = Console.ReadLine();
                        Console.WriteLine("gmail: ");
                        gm = Console.ReadLine();
                        Provedor tel3 = Provedor.EstablecerTelefono(numeroTelefonico, usi, gm);
                        tel3.Mostrar();
                        Console.ReadKey(); break;

                }

            } while (op!="4");
            
        }
        public static void movil()
        {
            App Fachada = new App();//utilizo nuevamente la consulta que tengo ya que en los banco se ultiza la app movil para eso

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("app movil ");
                Console.WriteLine("[1]Cuentas\n[2]Prestamos\n[3]Tarjetas\n[4]Cuentas de ahorro\n[5]atras");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Fachada.OperacionesCuentas();
                        break;
                    case 2:
                        Fachada.OperacionessPrestamos();
                        break;
                    case 3:
                        Fachada.OperacionesTarjetas();
                        break;
                    case 4: Fachada.OperacionesConsulta(); break;   
                }
            } while (opcion != 5);

        }

    }
}
