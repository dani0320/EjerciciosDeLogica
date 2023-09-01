using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Promedio de cuantas personas son mayores de 18 años. 

             int x, e, con = 0, acu = 0, promedio; 

             for(x = 0; x < 3; x++)
             {  
                Console.WriteLine("Ingrese un numero"); 
                e = int.Parse(Console.ReadLine());              
                
                if(e > 18)
                    { 
                      con++; 
                      acu+= e;
                    } 
                else if(e < 18)    
                    { 
                      con++; 
                      acu+= e; 
                    }
             }
             
             if(con != 0)
             { 
                promedio = acu / con; 
                Console.WriteLine("El promedio es: " + promedio); 
             }
             else 
             { 
                Console.WriteLine("NO se ingreso ningun numero mayor a 18 años"); 
             }
        }
    }
}
