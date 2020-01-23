using System;

namespace tarea1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrse z y c ");
            double z = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());

            double c = cGrados * (Math.PI / 180.0);


            double a = 180.0 - (cGrados + 90);
            Console.WriteLine("a:");
            Console.WriteLine(a);

            double y = (z / Math.Tan(c));
            Console.WriteLine("y:");
            Console.WriteLine(y);


            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            Console.WriteLine("t:");
            Console.WriteLine(t);

        }
    }
}
