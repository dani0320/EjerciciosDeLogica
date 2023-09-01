using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
            //El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            
            int n1, con = 0, acu = 0; 

            Console.WriteLine("Ingresar un numero(Cortar con cero)"); 
            n1 = int.Parse(Console.ReadLine()); 
            while (n1 != 0)
            {
                if(primo(n1))
                { 
                    con++; 
                    acu += n1; 
                }
                n1 = int.Parse(Console.ReadLine()); 
            }
            int promedio = acu / con; 
            Console.WriteLine("Se ha ingresado numeros primos: " + con); 
            Console.WriteLine("Y el promedio de los numeros primos es: " + promedio); 

        }

        static bool primo(int n1)
        { 
            int con = 0; 
            for (int x = 1; x <= n1; x++)
            {
                if(n1 % x == 0)
                    con++; 
            }
                if(con == 2)
                    return true; 
                else 
                    return false; 
        }
    }
}
