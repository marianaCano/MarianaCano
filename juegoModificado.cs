using System;

namespace Trabajo_Mariana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrse el numero de jugadores(max5,min2)");
            int n = int.Parse(Console.ReadLine());
            int jugador = 0, mayor = 0, ganador = 0;
           


            while (n > 5 || n < 2)
            {
                Console.WriteLine("Error. Ingrese el número de jugadores ");
                n = int.Parse(Console.ReadLine());
            }

            while (jugador < n)
            {
                
                Console.WriteLine("\n\n\n bienvenido jugador " + (jugador + 1) ) ;
                Random Caletorio = new Random();
                int carta1 = 0, carta2 = 0, Centregar = 0, Suma;
                string Continuar;
                carta1 = Caletorio.Next(1, 11);
                carta2 = Caletorio.Next(1, 11);
                Suma = carta1 + carta2;
                Console.WriteLine("Sus cartas son " + carta1 + "," + carta2);
                Console.WriteLine("Lleva " + Suma);
                Console.WriteLine("Quiere sacar una carta mas? (s/n)");
                Continuar = Console.ReadLine();
                while (Continuar != "s" && Continuar != "n")
                {
                    Console.WriteLine("Error. Recuerde que es s/n");
                    Continuar = Console.ReadLine();
                }


                while (Continuar == "S")
                {
                    Centregar = Caletorio.Next(1, 11);
                    Console.WriteLine("Recogió un: " + Centregar);
                    Suma = Suma + Centregar;
                    if (Suma >= 21)
                    {

                        Continuar = "n";

                    }
                    else
                    {

                        Console.WriteLine("Lleva " + Suma);
                        Console.WriteLine("Quiere sacar una carta mas? (S/N");
                        Continuar = Console.ReadLine();

                    }

                }
                if (Continuar == "N")
                {
                    if (Suma > 21)
                    {
                        Console.WriteLine("Tienes " + Suma);
                    }
                    else if (Suma == 21)
                    {
                        Console.WriteLine("Ganaste, tienes " + Suma);
                    }
                    else
                    {
                        Console.WriteLine("Total " + Suma);
                    }
                    Console.WriteLine("Gracias por participar.");
                    if (mayor < Suma)
                    {
                        mayor = Suma;
                        ganador = jugador;
                        
                    }

                    
                    
                }
                jugador++;

            }
            if (mayor == 0)
            {
                Console.WriteLine("\n\n\n NO HAY GANADORES");
            }
            else
                Console.WriteLine("\n\n\nGanó el jugador: " + (ganador + 1) + " con= " + mayor + " puntos");
        }
    }
}