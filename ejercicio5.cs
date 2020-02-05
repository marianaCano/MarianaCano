using System;

namespace tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese los datos correspondientes");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int blancos = int.Parse(Console.ReadLine());
            int anulados = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int mayores = (n * p) / 100;
            int total = (a + b + blancos + anulados);
            int d = 0;
            
            if (a > b)
            {
                d = a - b;
            }
            else
            {
                 d = b - a;
            }

            double x = n * 0.30;
            double y = n * 0.10;

            if (((total > n ) || (d < y)) && (total < x))
            {
                Console.WriteLine("las elecciones deben ser ejecutadas nuevamente");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("a es el partido ganador");
                }
                if (b > a)
                {
                    Console.WriteLine("b es el partido ganador");
                }
            }
        }
    }
}
