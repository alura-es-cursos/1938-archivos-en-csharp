using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscribeArchivoCSV()
    {
        var nombreArchivo = "CuentasExportadas.csv";

        using (var flujoDeArchivo = new FileStream(nombreArchivo, FileMode.Create))
        {
            var cuentaComoString = "375,4644,2483.13,Jonatan Silva";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(cuentaComoString);

            flujoDeArchivo.Write(bytes, 0, bytes.Length);
        }
        
    }


}
