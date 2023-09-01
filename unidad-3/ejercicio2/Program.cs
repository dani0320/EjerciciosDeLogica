using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

            int num1; 
            Console.WriteLine("Ingresar un numero: "); 
            num1 = int.Parse(Console.ReadLine()); 
            // Console.WriteLine("Ingresar un numero: "); 
            // num2 = int.Parse(Console.ReadLine()); 

            if(num1 > 0) 
                Console.WriteLine("Positivo"); 
            else if(num1 < 0)
                Console.WriteLine("Negativo");
                if(num1 == 0)
                Console.WriteLine("Igual a cero"); 
        }
    }
}
