using System;

class Program
{
    static void Main(string[] args)
    {

        double precio;
        double descuento;
        double total;

        Console.Write("Ingrese el precio del articulo: ");
        precio = Convert.ToDouble(Console.ReadLine());

        if (precio >= 1000 && precio <= 5000)
        {
            descuento = precio * 0.03;
            total = precio - descuento;
            Console.WriteLine("El precio del articulo es:" + precio);
            Console.WriteLine("El descuento es:" + total);
        }

        else if (precio >= 5001 && precio <= 10000)
        {
            descuento = precio * 0.05;
            total = precio - descuento;
            Console.WriteLine("El precio del articulo es:" + precio);
            Console.WriteLine("El descuento es:" + total);
        }

        else if (precio >= 10001 && precio <= 15000)
        {
            descuento = precio * 0.08;
            total = precio - descuento;
            Console.WriteLine("El precio del articulo es:" + precio);
            Console.WriteLine("El descuento es:" + total);
        }

        else if (precio >= 15001 && precio >= 20000)
        {
            descuento = precio * 0.10;
            total = precio - descuento;
            Console.WriteLine("El precio del articulo es:" + precio);
            Console.WriteLine("El descuento es:" + total);
        }


        else
        {
            Console.Write("No recibe descuento");
        }






    }
}
