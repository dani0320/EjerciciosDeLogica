using System;

namespace probandoCiclosCombinados
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR CON FOR: 
            // int n, promedio, acu = 0; 
            
            // for (int x = 0; x < 10; x++)
            // {   
            //     for (int i = 0; i < 20; i++)
            //     {
            //         Console.WriteLine("Ingrese las edades: "); 
            //         n = int.Parse(Console.ReadLine()); 
            //         acu += n; 
            //     }
            //     promedio = acu / 20; 
            //     Console.WriteLine("El promedio de todas las edades son: " + promedio); 
            // }

            
            
            //FOR CON WHILE 
            // int n, promedio, acu = 0, con = 0; 
            
            // for (int x = 0; x < 10; x++)
            // {   
            //     Console.WriteLine("Ingrese las edades: "); 
            //     n = int.Parse(Console.ReadLine()); 
            //             // acu = 0; 
            //             // con = 0;
            //     while (n != 0)
            //     {
            //         Console.WriteLine("Ingrese las edades: "); 
            //         n = int.Parse(Console.ReadLine()); 
            //         acu += n; 
            //         con++; 
            //     }
            //     promedio = acu / con; 
            //     Console.WriteLine("El promedio de todas las edades son: " + promedio); 
            // }


            // WHILE CON FOR
            // int n, promedio, acu = 0; 
            
            // Console.WriteLine("ingrese 1 para continuar o 0 para terminar."); 
            // n = int.Parse(Console.ReadLine());

            // while (n != 0)
            // {
            //     for (int x = 0; x < 20; x++)
            //     {
            //         Console.WriteLine("Ingrese la edad: "); 
            //         n = int.Parse(Console.ReadLine()); 
            //         acu += n; 
            //     }
            //     promedio = acu / 20; 
            //     Console.WriteLine("El promedio de edades es: " + promedio); 

            //     Console.WriteLine("ingrese 1 para continuar o 0 para terminar."); 
            //     n = int.Parse(Console.ReadLine()); 
            // }


            //WHILE CON WHILE 
            int n, promedio, con = 0, acu = 0; 

            Console.WriteLine("Ingrese un numero para continuar: "); 
            n = int.Parse(Console.ReadLine()); 
            while (n > 0)
            {
                while (n != 0)
                {
                    Console.WriteLine("Ingrese la edad: "); 
                    n = int.Parse(Console.ReadLine()); 
                    con++; 
                    acu += n; 
                }
                promedio = acu / con; 
                Console.WriteLine("El promedio de edades son: " + promedio); 

                Console.WriteLine("Ingrese 1 para continuar o 0 para terminar. "); 
                n = int.Parse(Console.ReadLine()); 
            }
        }
    }
}
