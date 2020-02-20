using System;

namespace dadoCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, dado2 = 0, contador = 0, suma = 0, vidas = 3;
            String play = "";
            Console.WriteLine("play con m ");
            play = Console.ReadLine();


            while (play == "m")
            {
                dado = aleatorio.Next(1, 7);
                dado2 = 0;
                contador++;
                suma += dado + dado2;
                Console.WriteLine("Sacó " + dado);
                if (contador % 2 == 0)
                {
                    vidas--;
                    Console.WriteLine("perdió una vida");
                }
                if (contador % 3 == 0)
                {
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Sacó en el segundo dado: " + dado2);
                }
                if (dado2 == dado)
                {
                    vidas++;
                    Console.WriteLine("Ganó 1 vida");
                }
                 
                if (vidas == 0)
                {
                    Console.WriteLine("Perdió. Tiene " + vidas + " vidas.");
                    play = "n";
                }

                else if (suma >= 100)
                {
                    Console.WriteLine("Ganó, sacó" + suma);
                    play = "n";
                }

                else
                {
                    Console.WriteLine("suma: " + suma + " y tiene: " + vidas + " vidas.");
                    Console.WriteLine("Continuar (s/n)?");

                    play = Console.ReadLine();

                }
            }
        }
    }
}
