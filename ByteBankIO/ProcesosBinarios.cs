using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscribirBinario()
    {
        var nombreArchivo = "VariablesBinarias.txt";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.CreateNew))
        using (var escritor = new BinaryWriter(flujoArchivo))
        {
            escritor.Write("Formación C#");
            escritor.Write(true);
            escritor.Write(false);
            escritor.Write((long)343768);
            escritor.Write(12121.12);
        }
    }

    static void LeerBinario()
    {
        var nombreArchivo = "VariablesBinarias.txt";

        using (var flujoArchivo = new FileStream(nombreArchivo, FileMode.Open))
        using (var lector = new BinaryReader(flujoArchivo))
        {
            var string1 = lector.ReadString();
            var bool1 = lector.ReadBoolean();
            var bool2 = lector.ReadBoolean();
            var int1  = lector.ReadInt64();
            var double1 = lector.ReadDouble();

            Console.WriteLine($"String1 {string1}");
            Console.WriteLine($"Bool1 {bool1}");
            Console.WriteLine($"Bool2 {bool2}");
            Console.WriteLine($"int1 {int1}");
            Console.WriteLine($"double {double1}");
        }
    }



}