using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio "si la suma de los dos primeros es mayor al producto del segundo con el tercero". 

            int n1, n2, n3, resultado; 

            Console.WriteLine("Ingrese el primer numero: "); 
            n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el segundo numero: "); 
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: "); 
            n3 = int.Parse(Console.ReadLine());
            
            //INTENTAR GUARDAR LAS VARIABLES EN OTAS VARIABLES. 
            //ejemplo: suma = n1 + n2; && producto = n2 * n3; 


            if((n1 + n2) > n2 * n3)
               Console.WriteLine("La suma de los dos primeros es mayor. ");
            else if(n2 * n3 > n1 + n2)         
               Console.WriteLine("La suma de los dos primeros no es mayor. "); 
        }
    }
}
