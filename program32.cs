using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrse su salario");
            double smmlv = double.Parse(Console.ReadLine());
            double smmlv2 = 877803 * 2;
            double smmlv3 = 877803 * 5;

            if (smmlv < smmlv2)
            {
                Console.WriteLine("tarifa A con cuota moderada de 3.400");
            }
            else if (smmlv2 <= smmlv && smmlv <= smmlv3)
            {
                Console.WriteLine("tarifa B con cuota moderada de 13.500");
            }
            else if (smmlv > smmlv3)
            {
                Console.WriteLine("tarifa C con cuota moderada de 35.600");
            }

        }
    }
}
