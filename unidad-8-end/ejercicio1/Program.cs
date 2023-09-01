using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int a, b; 

            Console.WriteLine("Ingrese el precio del articulo: "); 
            a = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese la cantidad vendida: "); 
            b = int.Parse(Console.ReadLine());

            int montoTotal; 
            montoTotal = producto(a, b); 
            Console.WriteLine("El producto de a y b es: " + montoTotal); 

        }


        static int producto(int a, int b)
        { 
            // int r; 
            // r = a * b; 
            return a * b; 
        }
    }
}
