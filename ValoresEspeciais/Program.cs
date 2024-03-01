﻿using System;

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
        }
    }
}