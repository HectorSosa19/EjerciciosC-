using System;

namespace MatrizIrregular
{
    class Program
    {
        private int[][] matriz;

        public void Cargar()
        {
            matriz = new int[5][];
            for (int f = 0; f < matriz.Length; f++)
            {
                matriz[f] = new int[f + 1];
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write("Ingrese componente:");
                    string linea = Console.ReadLine();
                    matriz[f][c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write(matriz[f][c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
