using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el numero de datos");
            int n = int.Parse(Console.ReadLine());
            string[] nombres = new string[n];
            int[] edades = new int[n];
            double mayor = 0, menor = 100, suma = 0, desviacion = 0, cercano = 100;
            string nMa = "", nMe = "",nombreCercano = "";
            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("EDAD: ");
                int edad = int.Parse(Console.ReadLine());
                edades[i] = edad;
                suma += edad;
                Console.Write("NOMBRE: ");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
                if (edades[i] < menor)
                {
                    menor = edades[i];
                    nMe = nombres[i];
                }
                if (edades[i] > mayor)
                {
                    mayor = edades[i];
                    nMa = nombres[i];
                }
            }
            double promedio = suma / n;
            for (int i = 0; i < edades.Length; i++)
            {
                desviacion += Math.Pow((edades[i] - promedio), 2);
                double sumaDiferencia = Math.Sqrt(Math.Pow((edades[i] - promedio), 2));

                if (sumaDiferencia < cercano)
                {
                    cercano = sumaDiferencia;
                    nombreCercano = nombres[i];
                }

            }

            double estandar = Math.Sqrt(desviacion / n);
            
            Console.WriteLine("el mayor es :" + nMa + "con una edad de:" + mayor);
            Console.WriteLine("el menor es :" + nMe + "con una edad de:" + menor);
            Console.WriteLine("el mas cercano  es =" + nombreCercano);
            Console.WriteLine("la desviacion estandar es =" + estandar);
            Console.WriteLine("el promedio es =" + promedio);





        }
    }
}
