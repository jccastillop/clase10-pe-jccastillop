using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Programa de nombres de meses");
        Console.WriteLine("-----------------------------------");

        Console.Write("Ingrese el numero del mes del primer semestre (1 - 6): ");
        int numeroMes;

        if (int.TryParse(Console.ReadLine(), out numeroMes))
        {
            string nombreMes;

            switch (numeroMes)
            {
                case 1:
                    nombreMes = "Enero";
                    break;
                case 2:
                    nombreMes = "Febrero";
                    break;
                case 3:
                    nombreMes = "Marzo";
                    break;
                case 4:
                    nombreMes = "Abril";
                    break;
                case 5:
                    nombreMes = "Mayo";
                    break;
                case 6:
                    nombreMes = "Junio";
                    break;
                default:
                    Console.WriteLine("Número de mes incorrecto. Ingrese un número del 1 al 6.");
                    return; // Termina el programa si el número es incorrecto.
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"El mes correspondiente al número {numeroMes} es {nombreMes}.");
            Console.WriteLine("-----------------------------------");
        }
        else
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido del 1 al 6.");
            Console.WriteLine("-----------------------------------");
        // AUTOEVALUACION 10 U20230466
        }
    }
}
