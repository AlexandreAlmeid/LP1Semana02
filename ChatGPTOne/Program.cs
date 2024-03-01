using System;
using System.Collections.Generic;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> perguntasReconhecidas = new Dictionary<string, string>
            {
                { "Qual é o teu nome?", "O meu nome é ChatGPTOne." },
                { "Qual é a tua cor preferida?", "A minha cor preferida é cinzento!" },
                { "Que horas são?", "Eu não tenho um relógio, peço desculpa! Mas tenho uma pista: estão perto do canto inferior direito do teu ecrã!" },
                { "Qual é o sentido da vida?", "Essa é uma pergunta difícil..." }
            };

            while (true)
            {
                Console.Write("Faz-me uma pergunta (ou escreve EXIT para sair): ");
                string perguntaDoUsuario = Console.ReadLine();

                if (perguntaDoUsuario.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Até à próxima!");
                    break;
                }

                if (perguntasReconhecidas.ContainsKey(perguntaDoUsuario))
                {
                    Console.WriteLine(perguntasReconhecidas[perguntaDoUsuario]);
                }
                else
                {
                    Console.WriteLine("Desculpa, não sei como responder a essa pergunta. Por favor, tenta outra pergunta.");
                }
            }
        }
    }
}