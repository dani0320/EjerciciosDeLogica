using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            //COLOCAR SIEMPRE LAS LLAVES CUANDO HAYA DOS LINEASSSS!!!!!
            int[] Vnum = new int[5]; 

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: "); 
                Vnum[x] = int.Parse(Console.ReadLine());             
            }

            int max = Vnum[0]; 
            int pos = 1;  
            
            for (int x = 0; x < 5; x++)
            {
                if(Vnum[x] > max)
                { 
                    max = Vnum[x]; 
                    pos = x + 1; 
                }
            }
            Console.WriteLine("El numero maximo es: " + max); 
            Console.WriteLine("La posicion del numero maximo es: " + pos);
            
            
            
            // int n, maximo = 0; 
            // int posicion = -1; 
            // int[] Vnum = new int[10]; 

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un nro: "); 
            //     n = int.Parse(Console.ReadLine());             
            //     Vnum[x] = n; 
                
            //     if(n > maximo)
            //     { 
            //        maximo = n; 
            //        posicion = x + 1; 
            //     }
            // }

            // Console.WriteLine("El numero maximo es: " + maximo); 
            // Console.WriteLine("La posicion del numero maximo es: " + posicion); 



           
           
            // int maximo = int.MinValue;
            // int posicionMaximo = -1;

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Ingrese un número: ");
            //     int numero = int.Parse(Console.ReadLine());

            //     if (numero > maximo)
            //     {
            //         maximo = numero;
            //         posicionMaximo = i + 1;
            //     }
            // }

            // Console.WriteLine("El máximo número ingresado es: " + maximo);
            // Console.WriteLine("Está en la posición: " + posicionMaximo);

        }
    }
}
