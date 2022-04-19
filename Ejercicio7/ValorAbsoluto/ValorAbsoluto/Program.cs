using System;

namespace ValorAbsoluto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1;
            string leer;
            Console.WriteLine("Ingresa un numero :"); leer = Console.ReadLine();
            Numero1 = int.Parse(leer);
            if (Numero1 >= 0)
            {
                Console.WriteLine("El numero " + Numero1 + " es positivo");
            }else if (Numero1 < 0)
            {
                Numero1 = Numero1 * -1; 
                Console.WriteLine("El signo cambiado es " + Numero1);
            }
            
        }
    }
}
