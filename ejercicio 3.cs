using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos 
            Console.WriteLine("ingrse los valores de w,d,x");
            double w= double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            // convertir a radianes
            double d = (dGrados * (Math.PI / 180));

            //operaciones
            double m = Math.PI - (d + (Math.PI / 2));
            double y = (w * Math.Sin(m)) - (x * Math.Sin((Math.PI / 2))) / Math.Sin((Math.PI / 2));

            //respuesta
            Console.WriteLine(y);


        }
    }
}
