using System;

namespace ejDeDiagramasFlujo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2; 

            Console.WriteLine("Ingrese un nro: "); 
            n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese un nro: "); 
            n2 = int.Parse(Console.ReadLine());
            
            int sumaresta = sumaResta(n1, ref n2); 
            Console.WriteLine("Resultados: " + sumaresta + " Y la resta del 1° con el 2° es: " + n2); 
            
            
            // int n1, n2; 

            // Console.WriteLine("Ingrese un nro: "); 
            // n1 = int.Parse(Console.ReadLine()); 
            // Console.WriteLine("Ingrese un nro: "); 
            // n2 = int.Parse(Console.ReadLine()); 

            // int rta = mayor(n1, n2); 
            // Console.WriteLine("El mayor de los nros es(CERO si son iguales): " + rta); 

        }

        static int sumaResta(int a, ref int b)
        { 
            int suma = a + b; 
            b = b - a; 
            return suma; 
        }
        
        
        
        
        
        
        
        
        // static int mayor(int a, int b)
        // {    
        //     if(a == b) 
        //         return 0; 
        //     if(a > b)
        //         return a; 
        //         return b;  
        // }
    }
}
