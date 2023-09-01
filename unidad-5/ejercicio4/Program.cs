using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
            // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            // int num1, con = 0; 
            // bool esPrimo = true; 

            // Console.WriteLine("ingrese un numero: "); 
            // num1 = int.Parse(Console.ReadLine());

            // for (int x = 2; x < num1; x++)
            // {
            //     // Console.WriteLine("ingrese un numero: "); 
            //     // num1 = int.Parse(Console.ReadLine()); 
               
            //     if(num1 % x == 0)
            //     { 
            //         esPrimtrue ; 
            //         break; 
            //     }   
            // }
            //     if(esPrimo)
            //     { 
            //         Console.WriteLine("Es Primo"); 
            //     }
            //     else
            //        Console.WriteLine("No es primo. ");    
            
            // int num1, con = 0, maximo; 
            // Console.WriteLine("Ingrese un numero: "); 
            // num1 = int.Parse(Console.ReadLine()); 
            
            // for (int x = 1; x <= num1; x++)
            // {
            //     if(num1 % x == 0)
            //     { 
            //        con++; 
            //     }
            // }
            
            // if(con == 2)
            // { 
            //    Console.WriteLine("El numero es primo. "); 
            // }
            // else 
            // { 
            //    Console.WriteLine("El numero NO es primo. "); 
            // }

            // int num1, con = 0, maximo = 0;
            // int primo = 0; 
            // for (int x = 0; x < 5; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: "); 
            //     num1 = int.Parse(Console.ReadLine()); 
            //     for (int i = 1; i <= num1; i++)
            //     {
            //         if(num1 % i == 0)   
            //            con++; 
            //     }
            //     if(con == 2)
            //     { 
            //         if(!primo)
            //         {
            //             maximo = num1; 
            //             primo = 1;
            //         }
            //         else
            //         { 
            //             if (num1 > maximo) 
            //                 maximo = num1; 
            //         }
            //     }
            // }

            // Console.WriteLine("El nro primo es: " + maximo); 

            //CICLO WHILE

            int nro1, x = 1, con = 0; 
            // bool primo = true; 
            
            Console.WriteLine("Ingrese un solo numero: "); 
            nro1 = int.Parse(Console.ReadLine()); 

            while (x <= nro1)
            {
                if (nro1 % x == 0)
                { 
                    con++; 
                }
                x++; 
            }
            if(con == 2)
            { 
                Console.WriteLine("El numero es primo. "); 
            }
            else 
            { 
                Console.WriteLine("El numero NO es primo. "); 
            }
            
        }    
    }
}
