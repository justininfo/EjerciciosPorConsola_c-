using System;

class Program
{
    static void Main(string[] args)
    {
        
        double edad ;
        string genero;
       

        Console.Write("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.Write("Ingrese su genero: ");
            genero = Convert.ToString(Console.ReadLine());


            if (genero == "Hembra" || genero == "hembra")
            {
                Console.Write("Puedes pasar gratis ");
            }

            else if (genero == "Hombre" || genero == "hombre")
            {
                Console.Write("Eres hombre, debes pagar para pasar");
            }
        }

        else
        {
            Console.Write("Eres menor de edad, no puedes pasar");
        }


    }
}
