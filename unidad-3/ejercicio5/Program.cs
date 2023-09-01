using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
             
             int numero1, numero2, numero3, numero4, mayor; 

             Console.WriteLine("Ingresar los numeros: "); 
             numero1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingresar los numeros: "); 
             numero2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingresar los numeros: "); 
             numero3 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingresar los numeros: "); 
             numero4 = int.Parse(Console.ReadLine());
             
             if(numero1 > 100)
                Console.WriteLine("El primer valor: " + numero1 + " es mayor a 100"); 
             if(numero2 > 100)   
                Console.WriteLine("El segundo valor: " + numero2 + " es mayor a 100"); 
             if(numero3 > 100)   
                Console.WriteLine("El tercero valor: " + numero3 + " es mayor a 100"); 
             if(numero4 > 100)
                Console.WriteLine("El cuarto valor: " + numero4 + " es mayor a 100"); 

            // Console.WriteLine("Los numeros mayores a 100..." ); 
            Console.WriteLine("Fin del programa."); 
              
        }
    }
}
