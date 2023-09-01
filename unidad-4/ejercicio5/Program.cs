using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.

            int n1, n2, n3, n4; 

            Console.WriteLine("Ingresa el primer nro: "); 
            n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingresa el segundo nro: "); 
            n2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingresa el tercer nro: "); 
            n3 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingresa el cuarto nro: "); 
            n4 = int.Parse(Console.ReadLine()); 

            if(n1 > n2 && n2 > n3 && n3 > n4)
               Console.WriteLine("Los numeros estan Ordenados decrecientemente."); 
            else
               Console.WriteLine("Los numeros NO estan Ordenados decrecientemente. ");    


            Console.WriteLine("Programa terminado");    

        }
    }
}
