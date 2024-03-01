using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio do cilindro: ");
            string raioInput = Console.ReadLine();

            Console.Write("Digite o valor da altura do cilindro: ");
            string alturaInput = Console.ReadLine();

            if (float.TryParse(raioInput, out float raio) && raio >= 0 && float.TryParse(alturaInput, out float altura) && altura >= 0)
            {
                float volume = MathF.PI * MathF.Pow(raio,2) * altura;
                float superficie = 2*MathF.PI*raio*(raio + altura);

                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine($"Área de superfície: {superficie}");
            }
            else
            {
                Console.WriteLine("Os valores inseridos para o raio e altura devem ser positivos!");
            }
        }
    }
}
