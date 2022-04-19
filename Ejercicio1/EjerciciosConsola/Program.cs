using System;

namespace EjerciciosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x, e, y;
            string leer;
            Console.WriteLine("Escribe tu primer numero :"); leer = Console.ReadLine();
            x = double.Parse(leer);
            Console.WriteLine("Esribe tu segundo numero :"); leer = Console.ReadLine();
            y = double.Parse(leer);
            e = x / y;
            Console.WriteLine("El resultado de la Division: "+ e);
            e = x % y;
            Console.WriteLine("El resto de la Division: " + e);

        }

    }
}

