using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n1, rta, con = 0; 

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: "); 
                n1 = int.Parse(Console.ReadLine()); 

                if(par(n1))
                { 
                    con++; 
                }
            }
            Console.Write("Los numeros pares son: " + con); 


        }

        static bool par(int n1)
        { 
            if(n1 % 2 == 0)
            
                return true; 
            else    
                return false; 
        }
    }
}
