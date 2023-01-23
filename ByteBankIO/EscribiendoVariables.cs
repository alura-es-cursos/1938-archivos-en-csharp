using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscribiendoVariablesNoString()
    {
        var nombreArchivo = "VariablesNoString.txt";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.CreateNew))
        using (var escritor = new StreamWriter(flujoArchivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(343768);
            escritor.WriteLine(12121.12);
        }
    }


}