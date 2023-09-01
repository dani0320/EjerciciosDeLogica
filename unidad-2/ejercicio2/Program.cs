using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        
            // ejercicio 2 - unidad 2 // 
        {   // VARIABLES DECLARADAS. // 
            int n1, cubo; 

            Console.WriteLine("Ingrese un numero: ");             
            n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Numero elevado al cubo: ");
            // num3 = int.Parse(Console.ReadLine()); 

            cubo = (n1 * n1 * n1); 
            Console.WriteLine("El resultado es: " + cubo );

        }
    }
}
