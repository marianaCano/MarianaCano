using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double factor = 180 / Math.PI;
            //ingreso de datos

            Console.WriteLine(" ingrse y y z");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //calculo 

            double a = Math.Atan(y / z);
            a *= factor;
            Console.WriteLine("a:");

            Console.WriteLine(a);

            double c = 180 - (a + 90);
            Console.WriteLine("c:");

            
                Console.WriteLine(c);

            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));

            Console.WriteLine("t:");


            Console.WriteLine(t);



        }   
    }
}