using ByteBankIO;
using System.Text;

partial class Program
{
    static void TrabajandoConFileStream()
    {
        var nombreArchivo = "Cuentas.txt";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.Open))
        {
            int numeroBytesLeidos = -1;
            var buffer = new byte[1024];

            while (numeroBytesLeidos != 0)
            {
                numeroBytesLeidos = flujoArchivo.Read(buffer, 0, 1024);
                escribirBuffer(buffer, numeroBytesLeidos);
            }

        }




        //public override int Read(byte[] buffer, int offset, int count);
        Console.WriteLine("\nFinalizada la lectura inicial");
        Console.ReadLine();

        static void escribirBuffer(byte[] buffer, int numeroBytesLeidos)
        {
            var utf8 = new UTF8Encoding();

            Console.Write(utf8.GetString(buffer, 0, numeroBytesLeidos));
            /*foreach(var cadaByte in buffer)
            {
                Console.Write(cadaByte);
                Console.Write(" ");
            }*/
            return;
        }
    }
}
