using System;

namespace Control_Ventas_Productos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CONTROL DE VENTAS DE PRODUCTOS ** ");
            Console.WriteLine("");


            int cantidad;
            double precio;

            Console.WriteLine("Ingrese la cantidad de productos a comprar: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto: ");
            precio = double.Parse(Console.ReadLine());

            double importe = cantidad * precio;
            double descuento = importe * 0.11;
            double total = importe - descuento;

            Console.WriteLine("El importe de ventas es de $"+importe.ToString("0.0")+" ,el descuento es de $"+descuento.ToString("0.0")+" y el total es de $"+total.ToString("0.0"));


























        }
    }
}
