using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        double sueldoBruto = pagoPorHora * horasTrabajadas;

        double tasaAFP = 2.87;
        double tasaSFS = 3.04;

        double descuentoAFP = (sueldoBruto * tasaAFP) / 100;
        double descuentoSFS = (sueldoBruto * tasaSFS) / 100;
        double totalDescuentos = descuentoAFP + descuentoSFS;

        double sueldoNeto = sueldoBruto - totalDescuentos;

        Console.WriteLine("\nDetalles del Sueldo:");
        Console.WriteLine($"Sueldo Bruto: {sueldoBruto:C}");
        Console.WriteLine($"AFP (2.87%): {descuentoAFP:C}");
        Console.WriteLine($"SFS (3.04%): {descuentoSFS:C}");
        Console.WriteLine($"Total Descuentos: {totalDescuentos:C}");
        Console.WriteLine($"Sueldo Neto: {sueldoNeto:C}");
    }
}
