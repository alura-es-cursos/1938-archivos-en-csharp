using ByteBankIO;
using System.Text;

var nombreArchivo = "Cuentas.txt";
int numeroBytesLeidos = -1;
var flujoArchivo = new FileStream(nombreArchivo, FileMode.Open);
var buffer = new byte[1024];

while(numeroBytesLeidos != 0)
{
    numeroBytesLeidos = flujoArchivo.Read(buffer, 0, 1024);
    escribirBuffer(buffer);
}



//public override int Read(byte[] buffer, int offset, int count);
Console.WriteLine("Finalizada la lectura inicial");
Console.ReadLine();

void escribirBuffer(byte[] buffer)
{
    var utf8 = new UTF8Encoding();

    Console.Write(utf8.GetString(buffer));
    /*foreach(var cadaByte in buffer)
    {
        Console.Write(cadaByte);
        Console.Write(" ");
    }*/
    return;
}