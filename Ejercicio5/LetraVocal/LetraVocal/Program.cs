using System;

namespace LetraVocal
{
    class Program
    {
        static void Main(string[] args)
        {
            string leer;
            char letra;
            Console.WriteLine("Ingresa una letra:"); 
            leer = Console.ReadLine();
            letra = char.Parse(leer);
            switch (letra)
            {
                case 'a':
                    Console.WriteLine("Es una vocal");
                    break;
                case 'e':
                    Console.WriteLine("Es una vocal");
                    break;
                case 'i':
                    Console.WriteLine("Es una vocal");
                    break;
                case 'o':
                    Console.WriteLine("Es una vocal");
                    break;
                case 'u':
                    Console.WriteLine("Es una vocal");
                    break;
                default:
                    Console.WriteLine("No es una vocal");
                    break;
            }
        }
    }
}
