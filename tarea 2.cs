using System;

namespace tarea1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrse t y a");
            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            double a = aGrados * (Math.PI / 180);
           
            
            double c = 180 -(aGrados + 90);
            Console.WriteLine("c:");
            Console.WriteLine(c);

            double z = (t * Math.Cos(a));
            Console.WriteLine("z:");
            Console.WriteLine(z);

            double y = (t * Math.Sin(a));
            Console.WriteLine("y:");
            Console.WriteLine(y);
        }
    }
}
