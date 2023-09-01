using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //minimo y la posición
            int x, num1, min = 0, pos = 0; 

            for(x = 0; x < 10; x++)
            { 
               Console.WriteLine("Ingrese un numero. "); 
               num1 = int.Parse(Console.ReadLine()); 
               
               if(x == 0)
               { 
                  min = num1;
                  pos = 1;  
               }
               else if(num1 < min)
               { 
                  min = num1;   
                  pos = x + 1; 
               }
            //    else if(num1 == 1)
            //    { 
            //       Console.WriteLine("El programa termino"); 
            //       break; 
            //    }
                  
            }
               Console.WriteLine("El numero es: " + min); 
               Console.WriteLine("El puesto del numero encontrado: " + pos); 

            //chat gpt
            // int x, num1, min = 0, pos = 0;

            // for (x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un número:");
            //     num1 = int.Parse(Console.ReadLine());

            //     if (x == 0 || num1 < min)
            //     {
            //         if (num1 == 1)
            //         {
            //             Console.WriteLine("El programa ha terminado.");
            //             break;
            //         }
                    
            //         min = num1;
            //         pos = x + 1;
            //     }
            // }

            // if (x == 10)
            // {
            //     Console.WriteLine("El número mínimo es: " + min);
            //     Console.WriteLine("La posición del número mínimo es: " + pos);
            // }


        }
    }
}
