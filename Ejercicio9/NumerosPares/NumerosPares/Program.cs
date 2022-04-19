    using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 26;
            while (numero >= 10)
            {
                Console.WriteLine(numero);
                numero = numero - 2;
            }
        }
    }
}
