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
            double x = double.Parse(Console.ReadLine());

            double sen = 0;

            for (double i = 0; i < 100; i++)
            {
                sen += ((Math.Pow((-1), i) / Factorial((2 * i) + 1)) * (Math.Pow(x, (2 * i + 1))));
                Console.WriteLine("el valor obtenido es =" + sen);
            }

        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}

