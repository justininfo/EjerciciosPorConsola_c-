using System;

class Program
{
    static void Main(string[] args)
    {
        
        double calificación;


        Console.Write("Ingrese la calificación del estudiante: ");
        calificación = Convert.ToDouble(Console.ReadLine());


        if (calificación > 100)
        {
            Console.WriteLine("La calificación no puede ser mayor a 100:");
        }

        else if (calificación >= 90)
        {
            Console.WriteLine("La calificacion del estudiante es:" + calificación);

            Console.WriteLine("El estudiante tuvo una calificacion excelente");
        }

        else if (calificación >= 80)
        {
            Console.WriteLine("La calificacion del estudiante es:" + calificación);

            Console.WriteLine("El estudiante tuvo una calificacion muy buena");
        }

        else if (calificación >= 75)
        {
            Console.WriteLine("La calificacion del estudiante es:" + calificación);

            Console.WriteLine("El estudiante tuvo una calificacion buena");
        }

        else if (calificación >= 70)
        {
            Console.WriteLine("La calificación ingresada fue: " + calificación);

            Console.WriteLine("¡La situación del estudiante esta regular!");
        }

        else 
        {
            Console.WriteLine("La calificación ingresada fue: " + calificación);

            Console.WriteLine("¡La situación del estudiante esta deficiente!");
        }

        


        



    }
}
