using System;

namespace probandoCicloFor
{
    class Program
    {
        static void Main(string[] args)
        {   //PRACTICANDO CON EL "FOR" POR PRIMERA VEZ.// 
            // float x; 
            // float acumulador = 0; 
            // float n1;

            // Console.WriteLine("Ingresa un numero: "); 
            // n1 = float.Parse(Console.ReadLine()); 

            // for(x = 0; x < 100; x--)
            // { 
            //     acumulador += n1; 
            // }  
            // float promedio = acumulador / 100F; 
            //     Console.WriteLine("El resultado del Promedio es: " + promedio); 


            // float n = 0, promedio, suma = 0; 

            // for (float x = 0; x < 5; x++)
            // {
            //     Console.WriteLine("Ingrese las notas. "); 
            //     n = float.Parse(Console.ReadLine()); 
            //     suma += n; 
            // }
            //     promedio = suma / 5; 
            //     Console.WriteLine("El promedio en total es: " + promedio);       



            // PROBANDO "FOR INFINITO"// 
            // for (int x = 0; x < 100; x--)
            // {
            //     Console.WriteLine("ola.... "); 
            // }                     


            //PROBANDO CICLO "WHILE"//                                                 
        
            int n, con = 0;                                                                

            // Console.WriteLine("Ingrese un nro: ");                               
            // n = int.Parse(Console.ReadLine()); 

            // while(n != 0){
            //     con++; 
            //     Console.WriteLine("Ingrese un nro: "); 
            //     n = int.Parse(Console.ReadLine()); 
            //  }
            //  Console.WriteLine("Ingresaste: " + con + " numeros."); 


            //"WHILE" IMITANDO A UN "FOR" 
            while(con < 20)
            { 
                con++; 
                Console.WriteLine(con); 
            }

            
            //PROBANDO EL CICLO "DO WHILE"// 
            
            //  float n = 0;

            //  do{
            //  n++;
            //  }while(n < 10); 
        }
    }
}
