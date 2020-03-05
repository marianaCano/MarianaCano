using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrse una frase");
            string frase  = Console.ReadLine();
            Console.WriteLine("de esta frase ingrse una palabra");
            string palabra = Console.ReadLine();
            frase = frase.ToUpper();
            palabra = palabra.ToUpper();
            int contadorP = 0;

            for (int i =0; i < frase.Length-palabra.Length; i++)
            {
                string palabraEncontrada = "";
                for(int j= 0; j < palabra.Length; j++)
                {
                    palabraEncontrada += frase[i + j];
                }

                if(palabraEncontrada == palabra)
                {
                    contadorP++;
                    Console.WriteLine("se econtro la palabra:" + palabra + "en la posicio:" + i );
                }
               
            }
            Console.WriteLine("Se repite: " + contadorP + " veces");
        }
    }
}
