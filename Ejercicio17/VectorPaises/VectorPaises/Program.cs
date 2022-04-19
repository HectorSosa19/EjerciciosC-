using System;

namespace VectorPaises
{
    class Program
    {
        private string[] paises;

        public void Cargar()
        {
            paises = new string[5];
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el nombre del pais:");
                paises[f] = Console.ReadLine();
            }
        }

        public void Ordenar()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        string aux;
                        aux = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Paises ordenados en forma alfabética:");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();
        }
    }
}
