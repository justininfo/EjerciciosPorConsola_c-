using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el sueldo del empleado:");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el número de hijos del empleado:");
        int numeroHijos = Convert.ToInt32(Console.ReadLine());


        if (numeroHijos > 0)
        {
            double incentivo = numeroHijos * 500;
            double total = sueldo + incentivo;

            Console.WriteLine("El sueldo del empleado es:" + sueldo);
            Console.WriteLine("Hijos del empleado:" + numeroHijos);
            Console.WriteLine("El empleado tuvo un incentivo de:" + incentivo);
            Console.WriteLine("Sueldo Total del empleado es:" +  total);
        }
        else
        {
            Console.WriteLine("No le corrresponde, lo siento.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();


    }
}