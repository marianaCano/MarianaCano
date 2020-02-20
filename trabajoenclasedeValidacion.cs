using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();  
            int a = aleatorio.Next(0, 11);
            int b = aleatorio.Next(0, 11);
            int sumaCorrecta = a + b;
            int oportunidades = 3;
            Console.WriteLine("ingrse la suma correcta de a + b");
            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            int suma = int.Parse(Console.ReadLine());
            

            while (sumaCorrecta != suma)
            {
                a = aleatorio.Next(0, 11);
                b = aleatorio.Next(0, 11);
                Console.WriteLine("incorrecto, intente otra vez");
                Console.WriteLine("ingrse la suma correcta de a + b");
                Console.WriteLine(" a = " + a);
                Console.WriteLine(" b = " + b);
                suma = int.Parse(Console.ReadLine());
                oportunidades--;
                if (oportunidades <= 0)
                {
                    Console.WriteLine("no puede ingresar");
                    break;
                }
            }

            if (1 <= oportunidades && oportunidades <= 3)
            {
                Console.WriteLine("puede continuar");
            }
            
        }
    }
}
