using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrse x");
           double  x = double.Parse(Console.ReadLine());

            double n = 100;
            double e = 0;

            for(double i = 0; i <100; i++)
            {
                e += Math.Pow(x, i) / Factorial(i);
                Console.WriteLine("el valor obtenido es =" + e);
            }
            
        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
