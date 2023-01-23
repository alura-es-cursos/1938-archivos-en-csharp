using ByteBankIO;
using System.Text;

partial class Program
{
    static void StreamDesdeConsola()
    {
        Console.InputEncoding = Encoding.Latin1;
        using (var flujoDeConsola = Console.OpenStandardInput())
        using (var escritor = new StreamWriter("salidaConsola.txt"))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var byteLeidos = flujoDeConsola.Read(buffer, 0, 1024);


                Console.WriteLine($"Bytes leídos: {byteLeidos}");
                var latin1 = Encoding.Latin1;
                
                escritor.Write(latin1.GetString(buffer, 0, byteLeidos));
                escritor.Flush();
            }


        }
    }


}