using System;

namespace tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrse su salario mensual");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrse 1 si es dependiente o 2 si es independiente");
            string opcion = Console.ReadLine();
            double salarioC = (salario * 0.40);
            double arl = 0;
            double slm = 877803;
            if (salarioC < slm) salarioC = slm;
            Console.WriteLine("ingrese su riesgo laboral");
            string riesgo = Console.ReadLine();
            switch (opcion)
        {
                case "2":
            switch (riesgo)
            {
                case "1":
                    arl = (salarioC * 0.522);
                    break;
                case "2":
                    arl = (salarioC * 1.044);
                    break;
                case "3":
                    arl = (salarioC * 2.436);
                    break;
                case "4":
                    arl = (salarioC * 4.350);
                    break;
                case "5":
                    arl = (salarioC * 6.960);
                    break;

            }
                    double pension2 = (salarioC * 0.16);
                    double eps2 = (salarioC * 0.125);
                    double SalarioM = salario - (pension2 + eps2 + arl);
                    Console.WriteLine("Salario mensual menos la reduccion " + SalarioM);

                    double Sanual = SalarioM * 12;
                    Console.WriteLine("Salario anual " + Sanual);
                    break;
                case "1":
                    double pension = (salarioC * 0.04);
                    double eps = (salarioC * 0.04);
                    double salarior= salario - (pension + eps);
                    Console.WriteLine("Salario mensual menos reducciones " + salarior);

                    double anual = (salarior * 12) + salario;
                    Console.WriteLine("Salario anual " + anual);
                    break;
        }
            

           






            }


        }
    }

