using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          //4.Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
              //NO PUDE RESOLVER ESTE CONSIGNA ADECUADAMENTE. 
          int num1, num2, num3, num4, menor; 

          Console.WriteLine("Ingrese los numeros: "); 
          num1 = int.Parse(Console.ReadLine()); 
          Console.WriteLine("Ingrese los numeros: "); 
          num2 = int.Parse(Console.ReadLine()); 
          Console.WriteLine("Ingrese los numeros: "); 
          num3 = int.Parse(Console.ReadLine()); 
          Console.WriteLine("Ingrese los numeros: "); 
          num4 = int.Parse(Console.ReadLine()); 

          if(num1 < num2 )
              menor = num1; 
            else
               menor = num2; 
            if(num3 < menor)
               menor = num3; 
            if(num4 < menor)
               menor = num4;  

          Console.WriteLine("El menor de todos es: " + menor); 


        }
    }
}
