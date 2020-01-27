using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos 
            Console.WriteLine("ingrse los valores de w,t,c");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cGrados= double.Parse(Console.ReadLine());

            // convertir a radianes
            double c = (cGrados * (Math.PI / 180));

            //operaciones
            double a = Math.PI - (c + (Math.PI / 2));
            double e = (Math.PI - c);
            double z = (t * Math.Sin(c)) / Math.Sin((Math.PI / 2));
            double y = (t * Math.Sin(a)) / Math.Sin((Math.PI / 2));
            double d = Math.Asin(z / w);
            double b = Math.PI - (d + e);
            double x = (t * Math.Sin(b)) / Math.Sin(d);

            //resultado
            Console.WriteLine(x);




        }
    }
}
