using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 1;
            do
            {
                Console.WriteLine(Numero);
                Numero = Numero + 1;
            }
            while (Numero <= 10);
            
        }
    }
}
