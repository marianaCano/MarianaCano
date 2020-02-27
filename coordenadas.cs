using System;

namespace coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coordenadas");
            double[] coordenadasX = { 0, 2,3,7 };
            double[] coordenadasY = { 0, 1, 5, 6 };
            double i = 0, max = 0;
            double pendiente1 = (coordenadasY[1] - coordenadasY[0]) / (coordenadasX[1] - coordenadasX[0]);
            double pendiente2 = (coordenadasY[2] - coordenadasY[0]) / (coordenadasX[2] - coordenadasX[0]);
            double pendiente3 = (coordenadasY[3] - coordenadasY[0]) / (coordenadasX[3] - coordenadasX[0]);
            double pendiente4 = (coordenadasY[2] - coordenadasY[1]) / (coordenadasX[2] - coordenadasX[1]);
            double pendiente5 = (coordenadasY[3] - coordenadasY[1]) / (coordenadasX[3] - coordenadasX[1]);
            double pendiente6 = (coordenadasY[3] - coordenadasY[2]) / (coordenadasX[3] - coordenadasX[2]);

            if (pendiente1 == pendiente2 && pendiente3 == pendiente4 && pendiente5 == pendiente6)
            {
                Console.WriteLine("pertenencen a la misma linea recta");
            }
            else Console.WriteLine("no pertenece a la misma recta");

            double distancia1 = Math.Sqrt(Math.Pow((coordenadasY[1] - coordenadasY[0]), 2) + Math.Pow((coordenadasX[1] - coordenadasX[0]), 2));
            if (distancia1 > max)
                max = distancia1;

            double distancia2 = Math.Sqrt(Math.Pow((coordenadasY[2] - coordenadasY[0]), 2) + Math.Pow((coordenadasX[2] - coordenadasX[0]), 2));
            if (distancia2 > max)
                max = distancia2;

            double distancia3 = Math.Sqrt(Math.Pow((coordenadasY[3] - coordenadasY[0]), 2) + Math.Pow((coordenadasX[3] - coordenadasX[0]), 2));
            if (distancia3 > max)
                max = distancia3;

            double distancia4 = Math.Sqrt(Math.Pow((coordenadasY[2] - coordenadasY[1]), 2) + Math.Pow((coordenadasX[2] - coordenadasX[1]), 2));
            if (distancia4 > max)
                max = distancia4;

            double distancia5 = Math.Sqrt(Math.Pow((coordenadasY[3] - coordenadasY[1]), 2) + Math.Pow((coordenadasX[3] - coordenadasX[1]), 2));
            if (distancia5 > max)
                max = distancia5;

            double distancia6 = Math.Sqrt(Math.Pow((coordenadasY[3] - coordenadasY[2]), 2) + Math.Pow((coordenadasX[3] - coordenadasX[2]), 2));
            if (distancia6 > max)
                max = distancia6;


            Console.WriteLine("La distancia max es " + max);




        }
    }
}
