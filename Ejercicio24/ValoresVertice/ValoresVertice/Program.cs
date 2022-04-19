using System;

namespace ValoresVertice
{
    class Program
    {
        private int[,] matriz;

        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            matriz = new int[filas, columnas];
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirVertices()
        {
            Console.WriteLine("Vértice superior izquierdo:");
            Console.WriteLine(matriz[0, 0]);
            Console.WriteLine("Vértice superior derecho:");
            Console.WriteLine(matriz[0, matriz.GetLength(1) - 1]);
            Console.WriteLine("Vértice inferior izquierdo:");
            Console.WriteLine(matriz[matriz.GetLength(0) - 1, 0]);
            Console.WriteLine("Vértice inferior derecho:");
            Console.WriteLine(matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1]);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.ImprimirVertices();
        }
    }
}
