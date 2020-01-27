using System;

namespace tarea_segunda_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine("ingrese los valores de: b,z,y");
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //convtidor a radianes
            double b = bGrados * (Math.PI / 180.0);

            //operaciones 

            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
           
            double c = Math.Asin(z / t);
            double cGrados = ((180 * c) / Math.PI);

            double e = Math.PI - c;

            double d = Math.PI - (e + b);

            double w = (t * Math.Sin(e)) / Math.Sin(d);

            double x = (t * Math.Sin(b)) / Math.Sin(d);
            Console.WriteLine(x);





                             


        }
    }
}
