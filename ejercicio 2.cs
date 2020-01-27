using System;

namespace ConsoleAppejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos 
            Console.WriteLine("ingrse los valores de d,b,y");
            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //paso a Rad
            double d= (dGrados * (Math.PI / 180));
            double b= (bGrados * (Math.PI / 180));

            //OPERACIONES
            double e = Math.PI - (d + b);
            double c = (Math.PI -e);
            double a = (Math.PI - (c + (Math.PI / 2)));
            double z = (y * Math.Sin(c)) / Math.Sin(a);

            //resultado
            Console.WriteLine(z);


        }
    }
}
