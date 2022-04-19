using System;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMERO1 = 0, NUMERO2 = 0;
            string LEER, RESULTADO;
            Program m = new Program();
            Console.WriteLine("Escribe el primer numero :"); LEER = Console.ReadLine();
            NUMERO1 = int.Parse(LEER);
            Console.WriteLine("Escribe el segundo numero :"); LEER = Console.ReadLine();
            NUMERO2 = int.Parse(LEER);
            RESULTADO = m.Multiplo(NUMERO1, NUMERO2);
            Console.WriteLine("{0} {1} de {2}", NUMERO1, RESULTADO, NUMERO2);
        }
        private string Multiplo(int numero1, int numero2)
        {
            string MENSAJE;
            int RESTO;
            RESTO = numero1 % numero2;

            if (RESTO == 0)
            {
                MENSAJE = "Es multiplo";
            }
            else
            {
                MENSAJE = "No es multiplo";
            }
            return MENSAJE;
        }
    }
    
}
