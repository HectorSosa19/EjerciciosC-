using System;

namespace TemperaturaPaises
{
    class Program
    {
        private string[] paises;
        private int[,] temperaturamensual;
        private int[] temperaturatrimestral;

        public void Cargar()
        {
            paises = new String[4];
            temperaturamensual = new int[4, 3];
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el nombre del país:");
                paises[f] = Console.ReadLine();
                for (int c = 0; c < temperaturamensual.GetLength(1); c++)
                {
                    Console.Write("Ingrese temperatura mensual:");
                    string linea = Console.ReadLine();
                    temperaturamensual[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirTempMensuales()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Pais:" + paises[f] + ":");
                for (int c = 0; c < temperaturamensual.GetLength(1); c++)
                {
                    Console.Write(temperaturamensual[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void CalcularTemperaturaTri()
        {
            temperaturatrimestral = new int[4];
            for (int f = 0; f < temperaturamensual.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < temperaturamensual.GetLength(1); c++)
                {
                    suma = suma + temperaturamensual[f, c];
                }
                temperaturatrimestral[f] = suma / 3;
            }
        }

        public void ImprimirTempTrimestrales()
        {
            Console.WriteLine("Temperaturas trimestrales.");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f] + " " + temperaturatrimestral[f]);
            }
        }

        public void PaisMayorTemperaturaTri()
        {
            int may = temperaturatrimestral[0];
            string nom = paises[0];
            for (int f = 0; f < paises.Length; f++)
            {
                if (temperaturatrimestral[f] > may)
                {
                    may = temperaturatrimestral[f];
                    nom = paises[f];
                }
            }
            Console.WriteLine("Pais con temperatura trimestral mayor es " + nom + " que tiene una temperatura de " + may);
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.ImprimirTempMensuales();
            ma.CalcularTemperaturaTri();
            ma.ImprimirTempTrimestrales();
            ma.PaisMayorTemperaturaTri();
            Console.ReadKey();
        }
    }
}
