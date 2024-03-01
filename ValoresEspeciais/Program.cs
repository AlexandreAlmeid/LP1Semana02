using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Byte: {byte.MinValue}\t{byte.MaxValue}");
            Console.WriteLine($"Int: {int.MinValue}\t{int.MaxValue}");
            Console.WriteLine($"Long: {long.MinValue}\t{long.MaxValue}");
            Console.WriteLine($"Float: {float.MinValue}\t{float.MaxValue}");
            Console.WriteLine($"Double: {double.MinValue}\t{double.MaxValue}");
            Console.WriteLine($"sByte: {sbyte.MinValue}\t{sbyte.MaxValue}");
            Console.WriteLine($"uInt: {uint.MinValue}\t{uint.MaxValue}");
            Console.WriteLine($"uLong: {ulong.MinValue}\t{ulong.MaxValue}");

            Console.WriteLine($"positiveInfinity: {float.PositiveInfinity}\t{double.PositiveInfinity}");
            Console.WriteLine($"negativeInfinity: {float.NegativeInfinity}\t{double.NegativeInfinity}");
            Console.WriteLine($"NaN: {float.NaN}\t{double.NaN}");

            long i = uint.MaxValue;
            Console.WriteLine((uint) (i + 1));

            float x = 2 * float.MaxValue;
            float y = float.MaxValue + 1;
            Console.WriteLine((float) (x));
            Console.WriteLine((float) (y));

            float f1, f2;
            f1 =f2 =10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);
        }
    }
}
