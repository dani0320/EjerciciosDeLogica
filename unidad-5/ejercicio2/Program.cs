using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            // int x, n1, mayor = 0; 
            
            // for(x = 0; x < 5; x++)
            // { 
            //     Console.WriteLine("Ingrese un numero"); 
            //     n1 = int.Parse(Console.ReadLine()); 
            //     // if(n1 > mayor)
            //     // { 
            //     //    mayor = n1; 
            //     // } 

            //     if(x == 0) 
            //        mayor = n1; 
            //     else{ 
            //         if(n1 > mayor)
            //             mayor = n1; 
            //     }   
            // }
            // Console.WriteLine("El mayor de todos es: " + mayor); 


            //CICLO WHILE

            int x = 1, n1, mayor = 0; 

            while (x <= 10)
            {
                x++;
                Console.WriteLine("Ingrese un numero: "); 
                n1 = int.Parse(Console.ReadLine());  

                if(x == 0)
                    mayor = n1; 
                else
                { 
                    if(n1 > mayor)
                    mayor = n1; 
                } 
                      
            }

            Console.WriteLine("El nro es mayor: " + mayor); 

        }
    }
}
