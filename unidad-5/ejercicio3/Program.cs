using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            
            // int n1, promedio = 0, con = 0, acu = 0,  mayor = 18; 

            // for(int x = 0; x < 5; x++)
            // { 
            //     Console.WriteLine("Ingrese el numero: "); 
            //     n1 = int.Parse(Console.ReadLine()); 

            //     if(n1 >= mayor)
            //     { 
            //        con++; 
            //        acu+= n1; 
            //     }
            // } 

            // if(con > 0)
            //     { 
            //         promedio = acu / con; 
            //         Console.WriteLine("El promedio de edad de personas mayores: " + promedio);    
            //     } 
            
            
            
            
            //CICLO WHILE 

            // int x = 0, n1, promedio = 0, con = 0, acu = 0, mayor = 18;  

            // while (x < 5)
            // {   x++; 
            //     Console.WriteLine("Ingrese la edad: "); 
            //     n1 = int.Parse(Console.ReadLine()); 

            //     if(n1 >= mayor)
            //     { 
            //         acu+= n1; 
            //         con++; 
            //     }
            // }    
            
            // promedio = acu / con; 
            // Console.WriteLine("El promedio de edad de mayores a 18 años o igual: " + promedio); 
            

            int x, con = 0; 
            
            while (x >= 18)
            {
                Console.WriteLine("Ingrese un nro: "); 
                x = int.Parse(Console.ReadLine()); 
                con++; 
                x++; 
               
                if(x >= 18)
                { 
                    con++; 
                }
            }

            Console.WriteLine("Las personas mayores a 18 años: " + con); 
        }
    }
}
