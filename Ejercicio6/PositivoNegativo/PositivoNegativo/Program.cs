using System;

namespace PositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1, Numero2;
            string leer; 
            Console.WriteLine("Digite el primer numero:");
            leer = Console.ReadLine();
            Numero1 = int.Parse(leer);
            Console.WriteLine("Digite el segundo numero:");
            leer = Console.ReadLine();
            Numero2 = int.Parse(leer);
            if (Numero1 > 0 && Numero2 > 0)
            {
                Console.WriteLine("Los dos números son positivos");
            }
            else if (Numero1 < 0 && Numero2 < 0)
            {
                Console.WriteLine("Los dos numeros son negativos");
            }
            else if (Numero1 > 0 && Numero2 < 0){
                Console.WriteLine("Uno de los numeros es positivo");
            }
            else if (Numero1 < 0 && Numero2 > 0)
            {
                Console.WriteLine("Uno de los numeros es positivo");
            }
            else if (Numero1 == 0 && Numero2 == 0)
            {
                Console.WriteLine("Ambos numeros son 0");
            }
            else 
            {
                Console.WriteLine("Ninguno de los números es positivo");
            }
        }
    }
}
