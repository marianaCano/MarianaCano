using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            string seguir = "", especial = "";
            int dadoUno = 0, contador = 0, contadorDos = 0, vidas = 3, contadorV = 0, dadoE1 = 0, contadorE = 0;

            dadoUno = aleatorio.Next(1, 13);
            dadoE1 = aleatorio.Next(1, 13);
           
            int total = dadoUno;

            Console.WriteLine("dado : " + dadoUno);
            Console.WriteLine("el total es: " + total);
            Console.WriteLine("vidas: " + vidas);

            Console.WriteLine("¿Desea tirar otra vez? (s/n)");
            seguir = Console.ReadLine();
            

            while (seguir == "s" && total < 100)
            {
                if (contadorE == 2)
                {
                    especial = "o";
                }
                else
                Console.WriteLine("¿Desea tirar el dado especial (y/o)");
                especial = Console.ReadLine();
                if (especial == "y")
                {
                    dadoE1 = aleatorio.Next(1, 13);
                    total += dadoE1;
                    contador++;
                    Console.WriteLine("el valor del dado especial: " + dadoE1);
                    Console.WriteLine("el total actual es : " + total);
                    Console.WriteLine("vidas: " + vidas);
                    contadorE ++;     
                }
                else

                if (especial != "y") { 
                    dadoUno = aleatorio.Next(1, 13);
                }
                else
               
                    total += dadoUno;
                    contador++;
                    Console.WriteLine("el valor del dado: " + dadoUno);
                    Console.WriteLine("el total actual es : " + total);
                    Console.WriteLine("vidas: " + vidas);
                

                
                if (total > 100)
                {
                    Console.WriteLine("Ganaste");
                    seguir = "n";
                }

                else
                {

                    Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                    seguir = Console.ReadLine();

                }

                if (dadoUno == 1) //condicion para las vidas
                {

                    contadorDos++;

                    if (contadorDos == 2)
                    {
                        vidas = vidas - 1;
                        total = total - 10;
                        Console.WriteLine("vidas: " + vidas);
                        Console.WriteLine("el total del dado es: " + total);
                        contadorDos = 0;

                    }
                }
                else


                 if (dadoUno == 6)
                {
                    contadorV = 1;
                }
                else {

                }
                
                if (dadoUno == 6 && contadorV == 1) //condicion del 6
                {
                    vidas++;
                    if (vidas > 3)
                    {
                        vidas = 3;
                    }
                }
                
              
                if (vidas ==0)
                {
                    Console.WriteLine("el total del dado es: " + total);
                    Console.WriteLine("perdiste");
                    Console.WriteLine("vidas: " + vidas);
                }
            
            }

            Console.WriteLine("el total del dado es: " + total);
            Console.WriteLine("se acabó el juego ");
            Console.WriteLine("vidas: " + vidas);
        }
    }
}

  
               
   