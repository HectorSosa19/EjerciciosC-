using System;

namespace Vectores
{
    class Program
    {
        private int[] vector;
        private int menor;
        public void Cargar()
        {
            Console.WriteLine("Cuantos elementos quiere cargar para el vector :");
            int numero = int.Parse(Console.ReadLine());
            vector = new int[numero];
            for (int contar= 0; contar < vector.Length; contar++)
            {
                Console.Write("Ingrese la cantidad de numeros propuestos :");
                vector[contar] = int.Parse(Console.ReadLine());
            }
        }
        public void MenorElemento()
        {
            menor = vector[0];
            for(int contar = 1; contar < vector.Length; contar++)
            {
                if (vector[contar] < menor)
                {
                    menor = vector[contar];
                }
            }
            Console.WriteLine("El elemento menor es:"+menor);
            RepiteMenor();
        }
        public void RepiteMenor()
        {
            int cantidad =0;
            for(int contar = 0; contar < vector.Length; contar++)
            {
                if (vector[contar] == menor)
                {
                    cantidad++;
                }
            }
            if (cantidad > 1)
            {
                Console.WriteLine("El elemento menor esta repetido en el vector");
            }
            else
            {
                Console.WriteLine("El elemento menor no esta repetido en el vector");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.MenorElemento();
            Console.ReadKey();
        }
    }
}
