using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    public class CuentaBancaria
    {
        public string NumeroCuenta { get; }
        public string NumeroAgencia { get; }
        public double Saldo { get; private set; }
        public Cliente Cliente{ get; set; }

        public CuentaBancaria(string _numero_cuenta, string _numero_agencia)
        {
            if (_numero_agencia == "")
            {
                throw new ArgumentException("Es necesario indicar el número de agencia", nameof(_numero_agencia));
            }
            if (_numero_cuenta == "")
            {
                throw new ArgumentException("Es necesario indicar el número de cuenta", nameof(_numero_cuenta));
            }
            NumeroCuenta = _numero_cuenta;
            NumeroAgencia = _numero_agencia;
            Cliente = new Cliente();
        }

        //Método DepositarDinero
        public void DepositarDinero(double valorADepositar)
        {
            if (valorADepositar < 0)
            {
                Console.WriteLine("No es posible depositar valores negativos");
                return;
            }
            Saldo += valorADepositar;
            return;
        }

        public bool RetirarDinero(double valorARetirar)
        {

            if (Saldo < valorARetirar)
            {
                throw new InvalidOperationException("No hay saldo suficiente para el retiro. Saldo Actual:" + Saldo + " - Monto a retirar:" + valorARetirar);
            }
            else if (valorARetirar <= 0)
            {
                throw new ArgumentException("No hay saldo suficiente para el retiro. Saldo Actual:" + Saldo + " - Monto a retirar:" + valorARetirar);
            }

            //saldo = saldo - valorARetirar;
            Saldo -= valorARetirar;

            return true;
        }
    }
}
