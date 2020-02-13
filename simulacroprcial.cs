using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dadoAleatorio = new Random();
            int dado1 = 0, dado2 = 0, dadoN1 = 0, dadoN2 = 0, turno = 1, turno2= 0, turno3 = 0;
            string continuar = "";
            dado1 = dadoAleatorio.Next(1, 7);
            dado2 = dadoAleatorio.Next(1, 7);
            int suma = dado1 + dado2;
            Console.WriteLine("sus dado 1  fue:" + dado1);
            Console.WriteLine("sus dado 2  fue:" + dado2);
            Console.WriteLine("para un total de :" + suma);
            if (1 == dado1 && dado2 == 1)
            {
                continuar = "n";
                Console.WriteLine("perdiste");
            }
            else  Console.WriteLine("quiere tirar otra vez?(s/n)");
            continuar = Console.ReadLine();

            if (suma > 6) turno2 += 1;

            while (continuar == "s")
            {
                
                dadoN1 = dadoAleatorio.Next(1, 7);
                dadoN2 = dadoAleatorio.Next(1, 7);
                suma += (dadoN1 + dadoN2);
                turno += 1;
                Console.WriteLine("sus dado 1  fue:" + dadoN1);
                Console.WriteLine("sus dado 2  fue:" + dadoN2);
                Console.WriteLine("para un total de :" + suma);

                if (1==dadoN1 && dadoN2 ==1)
                {
                    continuar = "n";
                    Console.WriteLine("perdiste");
                }
                else  if (suma >= 100)
                {
                    continuar = "n";
                    Console.WriteLine("ganaste");
                }
               
                else
                {
                    Console.WriteLine("para un total de :" + suma);
                    Console.WriteLine("quiere tirar otra vez?(s/n)");
                    continuar = Console.ReadLine();
                }
                if (suma > 6) turno2 += 1;
               
              
                if (dadoN1 == dadoN2) turno3 += 1;
                if (dado1 == dado2) turno3 += 1;

                if (turno3 == 3) Console.WriteLine("ganaste");

            }
           
            Console.WriteLine("veces que la suma fue 6 o mayor a 6 =" + turno2);
            Console.WriteLine("fin del juego");


        }
    }
}
