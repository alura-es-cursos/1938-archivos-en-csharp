using ByteBankIO;
using System.Text;

partial class Program
{
    static void RecursosAdicionales()
    {
        var lineas = File.ReadAllLines("Cuentas.txt");
        Console.WriteLine(lineas.Length);

        /*
        foreach(var linea in lineas)
        {
            Console.WriteLine(linea);
        }
        */

        var bytesLeidos = File.ReadAllBytes("Cuentas.txt");
        Console.WriteLine(bytesLeidos.Length);

        File.WriteAllLines("Cuentas2.txt", lineas);
    }


}