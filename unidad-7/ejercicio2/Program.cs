using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int[] numeros = new int [5]; 
            int promedio; 
            int acu = 0, con = 0; 
            
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: "); 
                numeros[x] = int.Parse(Console.ReadLine()); 
            }
            //promedio: ↓.  
            for (int x = 0; x < 5; x++)
            {
                acu += numeros[x]; 
                con++; 
            }   
            promedio = acu / con; 
            Console.WriteLine("El promedio es : " + promedio); 
            //numero mayor que el promedio: ↓. 
            for (int x = 0; x < 5; x++)
            {
                if(numeros[x] > promedio)
                { 
                    Console.WriteLine("Numero mayor al promedio: " + numeros[x]); 
                }
            }

            // int acu = 0; 
            // for (int x = 0; x < 10; x++)
            // {
            //     acu += numeros[x]; 
            // }
            // promedio = acu / 10; 
            // Console.WriteLine("El promedio es: " + promedio); 


        }
    }
}
