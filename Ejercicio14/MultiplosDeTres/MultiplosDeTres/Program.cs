using System;

namespace MultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 50;
            Console.WriteLine("Multiplos de tres");
            for(int contar = 1; contar <= numero; contar++)
            {
                if (contar % 3 == 0)
                {
                    Console.Write("{0}|", contar);
                }
            }
        }
    }
}
