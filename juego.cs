using System;

namespace Trabajo_Mariana
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Caletorio = new Random();
            int carta1 = 0, carta2 = 0, Centregar = 0, Suma;
            string Continuar;
            carta1 = Caletorio.Next(1, 11);
            carta2 = Caletorio.Next(1, 11);
            Suma = carta1 + carta2;

            Console.WriteLine("Sus cartas son " + carta1 + "," + carta2);
            Console.WriteLine("Lleva " + Suma);
            Console.WriteLine("Quiere sacar una carta mas? (S/N)");
            Continuar = Console.ReadLine();

            while(Continuar == "S")
            {
                Centregar = Caletorio.Next(1, 11);
                Console.WriteLine("Recogió un: " + Centregar);
                Suma = Suma + Centregar;
                if(Suma >= 21)
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
            if(Continuar == "N")
            {
                if(Suma > 21)
                {
                    Console.WriteLine("Tienes " + Suma);
                }
                else if(Suma == 21)
                {
                    Console.WriteLine("Ganaste, tienes " + Suma);
                }
                else
                {
                    Console.WriteLine("Total " + Suma);
                }
            }

        }
    }
}
