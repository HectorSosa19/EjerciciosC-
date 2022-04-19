using System;

namespace Productode0
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1, Numero2,Total;
            string leer;
            Console.WriteLine("Digita tu primer numero:");
            leer = Console.ReadLine();
            Numero1 = int.Parse(leer);
            if (Numero1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else {
                Console.WriteLine("Digita tu segundo numero:");
                leer = Console.ReadLine();
                Numero2 = int.Parse(leer);
                Total = Numero1 * Numero2;
                Console.WriteLine("El resultado es: "+ Total);
            }
            
        }
    }
}
