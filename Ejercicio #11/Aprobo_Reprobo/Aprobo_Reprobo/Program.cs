using System;

class Program
{
    static void Main()

    {
        Console.WriteLine("Ingresa el nombre del estudiante:");
        string estudiante = Console.ReadLine();

        Console.WriteLine("Ingresa la primera calificación:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la segunda calificación:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la tercera calificación:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la cuarta calificación:");
        double nota4 = Convert.ToDouble(Console.ReadLine()); 


        Console.WriteLine("El nombre del estudiante es:" + estudiante);
        double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("Tu promedio es: " + promedio);

        if (promedio >= 70)
        {
            Console.WriteLine("Felicidades, has pasado! tu nota fue de:" + promedio);
        }
        else
        {
            Console.WriteLine("No has pasado, debes ir a completivo.");
            Console.WriteLine("Ingresa tu calificación de completivo:");
            double notaCompletivo = Convert.ToDouble(Console.ReadLine());

            double promedioCompletivo = promedio + notaCompletivo * 0.1;

            if (promedioCompletivo >= 70)
            {
                Console.WriteLine("Felicidades, has pasado con la calificación del completivo! con:" + promedioCompletivo);
            }
            else
            {
                Console.WriteLine("No has pasado el completivo, debes ir a extraordinario.");
                Console.WriteLine("Ingresa tu calificación de extraordinario:");
                double notaExtraordinario = Convert.ToDouble(Console.ReadLine());

                double promedioExtraordinario = promedio * 0.70 + notaExtraordinario * 0.30;

                if (promedioExtraordinario >= 70)
                {
                    Console.WriteLine("Felicidades, has pasado con la calificación del extraordinario! con:" + promedioExtraordinario);
                }
                else
                {
                    Console.WriteLine("Lo siento, no has pasado.");
                }
            }
        }
    }
}
