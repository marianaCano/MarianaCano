using System;

namespace dado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            string seguir = "";
            int dadoUno = 0, contador = 0, contadorDos = 0;
            
            dadoUno = aleatorio.Next(1, 13);
            int total = dadoUno;


            Console.WriteLine("el valor del dado uno : " + dadoUno);
            Console.WriteLine("el total es: " + total);

            Console.WriteLine("¿Desea tirar otra vez? (s/n)");
            seguir = Console.ReadLine();



            while (seguir == "s" && total < 100)
            {
                dadoUno = aleatorio.Next(1, 13);
                total += dadoUno;
                contador++;
                Console.WriteLine("el valor del dado: " + dadoUno);
                Console.WriteLine("el total actual es : " + total);

                if (dadoUno != 12) //condicion para que el contador se vuelva 1 
                { 
                    contadorDos = 0; 
                } 
                else 
                { 
                    contadorDos++; 
                }

                if ((contador > 3) && ((dadoUno % 2) != 0)) //condicion para que sea impar 
                {
                    Console.WriteLine("Te salió un impar, terminó el juego");
                    seguir = "n";
                }
                else if ((contador > 3) && (contadorDos == 1 && dadoUno == 10)) 
                {
                    Console.WriteLine("Ganaste");
                    seguir = "n";

                }
                else if (total > 100)
                {
                    Console.WriteLine("terminó el juego");
                    seguir = "n";

                }
                else
                {
                    Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                    seguir = Console.ReadLine();

                }


            }

            Console.WriteLine("el total del dado es: " + total);
            Console.WriteLine("gracias por participar");

        }
    }
}
