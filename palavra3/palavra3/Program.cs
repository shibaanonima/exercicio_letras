using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas letras tem na sua palavra:");
            int x = int.Parse(Console.ReadLine());
            string palavracompleta = "";
            string palavra = "";
            char[] letra = new char[x];
            int i;

            for (i = 0; i < x; i++)
            {
                Console.Write("Digite a {0}º letra:", i + 1);
                letra[i] = char.Parse(Console.ReadLine());
                palavra = palavra + letra[i];
                palavracompleta = palavra;
                Console.WriteLine(palavracompleta);
            }

            Console.WriteLine();

            for (i = 0; i < x; i++)
            {
                Console.WriteLine("{0} letra:{1} ", i + 1, letra[i]);
            }
            Console.WriteLine(palavracompleta);

            Console.Write("Digite uma letra para buscar na palavra:");

            char busca = char.Parse(Console.ReadLine());
            if (palavracompleta.Contains(busca))
            {
                Console.WriteLine("A palavra: {0} está presente.", busca);
            }

            else
            {
                Console.WriteLine(" Não tem a letra {0}", busca);
            }

            Console.ReadKey();


        }
    }
}