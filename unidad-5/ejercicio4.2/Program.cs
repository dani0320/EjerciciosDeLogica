using System;

namespace ejercicio4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un Programa que vaya del 10 al 1. 

            // for(int x = 10; x >= 1; x--)
            //     Console.WriteLine(+ x); 

            //CICLO WHILE 

            // int x = 0; 

            // while (x <= 100)
            // {
            //     Console.WriteLine(x); 
            //     x+= 5; 
                
            // }    

            // Console.WriteLine("Numeros del 1 al 100: " + x); 

            //maximo y posicion

            // int n = 0, max = n; 
            // int p = 1, pmax = p; 

            // while(n != 0)
            //     Console.WriteLine("Ingrese un numero: "); 
            //     n = int.Parse(Console.ReadLine()); 
            // { 
            //     if(n == 0)
            //         break; 
            //     p++; 
                
            //     if(n > max)
            //     { 
            //         max = n; 
            //         pmax = p; 
            //     }

            // }

            // Console.WriteLine("El numero maximo: " + max); 
            // Console.WriteLine("Su posicion es: " + pmax); 


                int max = 0; 
                int pmax = -1; 

                int p = 0;
                int n;
                bool hayNumeros = false;

                while (true)
                { 
                    Console.WriteLine("Ingrese un numero (0 para salir): "); 
                    n = int.Parse(Console.ReadLine()); 
                    p++; 

                    if (n == 0)
                    {
                        break; // Salir del bucle si se ingresa 0
                    }

                    if (!hayNumeros || n > max)
                    { 
                        max = n; 
                        pmax = p; 
                    }

                    hayNumeros = true;
                }

                if (hayNumeros)
                {
                    Console.WriteLine("El numero maximo: " + max); 
                    Console.WriteLine("Su posicion es: " + pmax);
                }
                else
                {
                    Console.WriteLine("No se ingresaron numeros distintos de cero.");
                }   

        }
    }
}
