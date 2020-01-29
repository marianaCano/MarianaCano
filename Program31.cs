using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine(" ingrse su salario");
            double smmlv = double.Parse(Console.ReadLine());
            double smmlv2 = 877803 * 2;
            double smmlv3 = 877803 * 4;

           

            if (smmlv < smmlv2 )
            { 
                Console.WriteLine("tarifa A");
            }
            else if ( smmlv2 <= smmlv && smmlv <= smmlv3 )
            {
                Console.WriteLine("tarifa B");
            }
             else if (smmlv > smmlv3 )
            {
                Console.WriteLine("tarifa C");
            }

        }
    }
}
