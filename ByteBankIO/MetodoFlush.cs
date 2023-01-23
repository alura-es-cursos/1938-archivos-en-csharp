using ByteBankIO;
using System.Text;

partial class Program
{
    static void VerificandoMetodoFlush()
    {
        var nombreArchivo = "CuentasExportadasConFlush.csv";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.CreateNew))
        using (var escritor = new StreamWriter(flujoArchivo))
        {
            for(int i = 0;i < 100000;i++)
            {
                string stringPrueba = $"Linea:{i}";
                escritor.WriteLine(stringPrueba);
                escritor.Flush();
                Console.WriteLine($"Escribimos la linea {i}");
                Console.ReadLine();
            }           
        }
    }


}