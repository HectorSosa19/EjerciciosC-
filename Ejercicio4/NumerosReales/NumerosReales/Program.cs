using System;

namespace NumerosReales
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1, Numero2, Total;
            string leer;
            Console.WriteLine("Escribe el primer valor : "); leer = Console.ReadLine();
            Numero1 = int.Parse(leer);
            Console.WriteLine("Escribe el segundo valor : "); leer = Console.ReadLine();
            Numero2 = int.Parse(leer);
            if (Numero2 != 0)
            {
                Total = Numero1 / Numero2;
                Console.WriteLine("El resultado es :"+ Total);
            }else
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }

        }
    }
}
