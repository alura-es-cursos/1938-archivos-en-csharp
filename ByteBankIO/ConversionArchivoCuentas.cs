using ByteBankIO;
using System.Text;

partial class Program
{
    static void ConversionArchivoCuentas()
    {
        var nombreArchivo = "Cuentas.txt";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.Open))
        {
            var lector = new StreamReader(flujoArchivo);

            //var linea = lector.ReadLine();
            //var contenido = lector.ReadToEnd();
            //var caracter = lector.Read();

            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                CuentaBancaria cuentaRegistrada = convertirLineaCuentaBancaria(linea);

                string msgLinea = $"Titular: {cuentaRegistrada.Cliente.Nombre}. Cuenta No. {cuentaRegistrada.NumeroCuenta} - Agencia No. {cuentaRegistrada.NumeroAgencia}. Saldo: {cuentaRegistrada.Saldo} ";
                Console.WriteLine(msgLinea);
            }

        }
        Console.ReadLine();
    }

    static CuentaBancaria convertirLineaCuentaBancaria(string linea)
    {
        var campos = linea.Split(',');
        CuentaBancaria cuenta = new CuentaBancaria(campos[1], campos[0]);
        Cliente cliente = new Cliente();
        cliente.Nombre = campos[3];
        cuenta.Cliente = cliente;
        var saldoInicial = double.Parse(campos[2]);

        cuenta.DepositarDinero(saldoInicial);


        return cuenta;
    }
}
