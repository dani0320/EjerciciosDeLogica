using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            // El fin de la carga se notifica con un número negativo. 
            // Luego mostrar cuántos números tiene cada lista.

            int n1, con; 

            do
            {   con = 0; 
                Console.WriteLine("Ingrese un número: "); 
                n1 = int.Parse(Console.ReadLine()); 
                while (n1 > 0)
                {   con++; 
                    n1 = int.Parse(Console.ReadLine()); 
                }
                Console.WriteLine("El total de nros es: " + con); 
            }while (n1 >= 0); 
        }
    }
}
