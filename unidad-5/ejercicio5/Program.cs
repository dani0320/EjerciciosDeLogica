using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            //Utilizando la variable "bandera" (es un tipo de dato booleano) o sea true o false. 
            // int a, maximo = 0, minimo = 0, conPar = 0, conImpar = 0; 
            // bool banPar = false, banImpar = false; 
            // for (int x = 0; x < 4; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: "); 
            //     a = int.Parse(Console.ReadLine());

                // if(a % 2 == 0 && a > maximo)
                // { 
                //     maximo = a; 
                // }
                // else if(a % 2 != 0 && a < minimo)
                // {
                //     minimo = a; 
                // }   

            //     if(a % 2 == 0)              //CODIGO HECHO POR MAXI.
            //     { 
            //        if(banPar == false)
            //        { 
            //             maximo = a; 
            //             banPar = true; 
            //             // conPar++; 
            //        }
            //       else if(a > maximo)
            //             maximo = a; 
            //     }

            //     else
            //     {
            //         if(banImpar == false) 
            //         { 
            //             minimo = a; 
            //             banImpar = true; 
            //             // conImpar++; 
            //         }
            //         else if(a < minimo)     
            //              minimo = a; 
            //     }
            // }
            //     Console.WriteLine("El numero maximo par es: " + maximo); 
            //     Console.WriteLine("El numero minimo impar es: " + minimo); 


             int x = 0, nro1, maximo = 0, minimo = 0, con = 0; 
            bool banPar = false, banImpar = false; 

            while (x < 5)
            {
                Console.WriteLine("Ingrese un numero"); 
                nro1 = int.Parse(Console.ReadLine()); 
                if(nro1 % 2 == 0)
                { 
                    if(banPar == false)
                    { 
                        banPar = true; 
                        con++; 
                        maximo = nro1; 
                    }
                    else if(x > maximo)
                        maximo = nro1; 
                }

                else
                { 
                    if(banImpar == false)
                    { 
                        banImpar = true; 
                        minimo = nro1; 
                        con++; 
                    }
                    else if(nro1 < minimo)
                        minimo = x; 
                }
                x++; 
            }
                Console.WriteLine("El numero maximo par es : " + maximo); 
                Console.WriteLine("El numero minimo impar es: " + minimo);
            
        }
    }
}
