using System;

namespace ColumnaMatriz
{
    class Program
    {
        private int[,] matriz;
        public void Cargar()
        {
            matriz = new int[2,5];
            for (int c = 0; c < 5; c++)
            {
                for(int f= 0; f < 2; f++)
                {
                    Console.Write("Ingrese el elemento de la fila "+f+"y la columna"+c+":");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Imprimir()
        {
            for(int f= 0;f<2; f++)
            {
                for(int c = 0; c < 5; c++) 
                {
                    Console.Write(matriz[f,c]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            m.Cargar();
            m.Imprimir();
            Console.ReadKey();
        }
    }
}
