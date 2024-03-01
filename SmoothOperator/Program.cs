using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro não-negativo: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number) && number >= 0)
            {
                // Converter o número para o tipo byte
                byte n = (byte)number;

                // Realizar as operações de decremento e incremento
                byte decrementResult = (byte)(n - 1);
                byte incrementResult = (byte)(n + 1);
                byte divisionResult = (byte)(n / 2);
                byte shiftleftResult = (byte)(n << 3);
                byte xorResult = (byte)(n ^ 5);
                bool isBigger = (bool)(n > 10);


                // Mostrar os resultados
                Console.WriteLine($"Resultado da operação de decremento de n: {decrementResult}");
                Console.WriteLine($"Resultado da operação de incremento de n: {incrementResult}");
                Console.WriteLine($"Resultado da operação de divisão de n: {divisionResult}");
                Console.WriteLine($"Resultado da operação de deslocamento de n: {shiftleftResult}");
                Console.WriteLine($"Resultado da operação de ou exclusivo de n: {xorResult}");
                Console.WriteLine($"Resultado da operação de comparação de n: {isBigger}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro não-negativo.");
            }
        }
    }
}

//Caso o utilizador insira zero, 