using System;

namespace IntercambiarFilaMatriz
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

        public void Intercambiar()
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                int aux = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = aux;
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.Intercambiar();
            ma.Imprimir();
        }
    }
}
