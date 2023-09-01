using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            //CICLO FOR CON WHILE.     
            // int n1, primo = 0; 

            // for (int x = 1; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: "); 
            //     int divisor = 2; 
            //     bool esPrimo = true;   
            //     n1 = int.Parse(Console.ReadLine()); 

            //     while (divisor < n1)
            //     {
            //         if(n1 % divisor == 0)
            //         { 
            //             esPrimo = false; 
            //             break; 
            //         }
            //         divisor++; 
            //     }
            //     if(esPrimo)
            //     { 
            //         primo++; 
            //     }
                
            // }
            // Console.WriteLine("Los numeros PRIMOS en total son: " + primo); 

            //CICLO FOR CON FOR. 

            int n1, con, esPrimo = 0; 

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los numeros: "); 
                n1 = int.Parse(Console.ReadLine()); 

                con = 0; 
                for (int y = 1; y <= n1; y++)
                {
                    if(n1 % y == 0)
                    { 
                        con++; 
                    }
                }
                if(con == 2)
                { 
                    esPrimo++; 
                }
            }
                Console.WriteLine("Los numeros primos en total son: " + esPrimo); 
        }
    }
}
