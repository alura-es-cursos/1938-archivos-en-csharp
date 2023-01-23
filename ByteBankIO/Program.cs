using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var nombreArchivo = "Cuentas.txt";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.Open))
        {
            var lector = new StreamReader(flujoArchivo);

            //var linea = lector.ReadLine();
            //var contenido = lector.ReadToEnd();
            //var caracter = lector.Read();

            while(!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Console.WriteLine(linea);
            }
                        
        }
        Console.ReadLine();
    }
}
