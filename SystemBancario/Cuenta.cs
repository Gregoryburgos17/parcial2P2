using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBancario
{
    class Cuenta 
    {
        public int cuentas;
        public double monto;

      
        public Cuenta(int num)
        {
           cuentas = num;
        }

        public double Depositar(double balance)
        {
            monto += balance;
            return monto;
        }
        public double Retirar(double balance)
        {
            monto -= balance;
            return monto;
        }

        public string consulta()
        {
            return($"su balance es{monto}");
        }
        
    }

}
