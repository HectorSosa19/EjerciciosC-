using System;

namespace ParesDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 26;
            do
            {
                Console.WriteLine(Numero);
                Numero = Numero - 2;
            }
            while (Numero >= 10);

        }
    }
}
