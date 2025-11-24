using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavracompleta = "";
            string palavra = "";
            char[] letra = new char[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite a {0} letra:", i + 1);
                letra[i] = char.Parse(Console.ReadLine());
                palavra = palavra + letra[i];
                palavracompleta = palavra;
                Console.WriteLine(palavracompleta);
            }

            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} letra:{1} ", i + 1, letra[i]);
            }

            Console.WriteLine(palavracompleta);
            Console.ReadKey();

        }
    }
}