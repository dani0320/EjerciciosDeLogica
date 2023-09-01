using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

            int n1;
            int n10 = 10; // DECLARAR SU VALOR //

            Console.WriteLine("Ingrese un numero en pantalla: "); // NO COLOCAR ADENTRO DEL IF //
            n1 = int.Parse(Console.ReadLine()); 

            if(n1 > n10){
                Console.WriteLine("Mayor a 10"); 
            }else{ 
                Console.WriteLine("Menor a 10"); 
            }








            // int n1 = 9; 
            // int n10 = 10; 

            // if(n1 > n10){
            //       if(n1 < n10){ 
            //         Console.WriteLine("Menor a 10"); 
            //       }else{
            //         Console.WriteLine("Mayor a 10"); 
            //     }    
            // }   
            // Console.WriteLine("Fin del programa");         
        }
    }
}
