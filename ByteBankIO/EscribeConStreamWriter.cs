using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscribeArchivoStreamWriter()
    {
        var nombreArchivo = "CuentasExportadas.csv";
        var cuentaComoString = "316,3254,3350.37,Leonardo";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.Create))
        using (var escritor = new StreamWriter(flujoArchivo))
        {
            
            escritor.Write(cuentaComoString);
        }
           
    }


}
