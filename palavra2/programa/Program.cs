using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas letras tem a palavra que você quer escrever: ");
            int x = int.Parse(Console.ReadLine());

            char[] letra = new char[x];
            string palavracompleta="";
            int i;
            string palavra = "";

            for (i = 0; i < x; i++)
            {
                Console.Write("Digite a {0} letra : ", i + 1);
                letra[1] = char.Parse(Console.ReadLine());
                palavra = palavra + letra[i];
                palavracompleta = palavra;
                Console.WriteLine(palavracompleta);

            }

            Console.WriteLine();

            for (i = 0; i < x; ++i)
            {
                Console.WriteLine("{0} letra: {1} ", i + 1, letra[i]);
            }

            Console.ReadKey();
        }
    }
}