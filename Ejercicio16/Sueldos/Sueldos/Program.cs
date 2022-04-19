using System;

namespace Sueldos
{
    class Program
    {
        private int[] sueldos;

        public void Cargar() 
        {
            sueldos=new int[5];
            for(int f=0;f < sueldos.Length;f++) 
            {
                Console.Write("Ingrese el sueldo:");
                string linea = Console.ReadLine();
                sueldos[f]=int.Parse(linea);
            }
        }

        public void Ordenar()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (sueldos[f] > sueldos[f + 1])
                    {
                        int aux;
                        aux = sueldos[f];
                        sueldos[f] = sueldos[f + 1];
                        sueldos[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir() 
        {
            Console.WriteLine("Sueldos ordenados de menor a mayor.");
            for(int f=0;f < sueldos.Length;f++) 
            {
                Console.WriteLine(sueldos[f]);
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
