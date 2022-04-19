using System;

namespace PaisHabitantes
{
    class Program
    {
        private string[] paises;
        private int[] habitantes;

        public void Cargar()
        {
            Console.WriteLine("Ingrese 5 nombres de paises y la cantidad de sus habitantes");
            paises = new string[5];
            habitantes = new int[5];
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese nombre de pais: ");
                paises[i] = Console.ReadLine();
                Console.Write("Ingrese cantidad de habitantes: ");
                habitantes[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public void OrdenarPorNombres()
        {
            for (int k = 0; k < paises.Length; k++)
            {
                for (int f = 0; f < paises.Length - 1 - k; f++)
                {
                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        string auxpais;
                        auxpais = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxpais;
                        int auxhabitante;
                        auxhabitante = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = auxhabitante;
                    }
                }
            }
        }

        public void OrdenarPorHabitantes()
        {
            for (int k = 0; k < paises.Length; k++)
            {
                for (int f = 0; f < paises.Length - 1 - k; f++)
                {
                    if (habitantes[f] < habitantes[f + 1])
                    {
                        string auxpais;
                        auxpais = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxpais;
                        int auxhabitante;
                        auxhabitante = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = auxhabitante;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f] + " - " + habitantes[f]);
            }
        }
        static void Main(string[] args)
        {
            Program vec = new Program();
            vec.Cargar();
            vec.OrdenarPorNombres();
            Console.WriteLine("Ordenados alfabéticamente");
            vec.Imprimir();
            vec.OrdenarPorHabitantes();
            Console.WriteLine("Ordenados por cantidad de habitantes");
            vec.Imprimir();
        }
    }
}
