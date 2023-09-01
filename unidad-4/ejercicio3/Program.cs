﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
            //           i5 (1)	    i7 (2)	     i9 (3)
            // 8 RAM (1) USD 800	USD 900	     USD 1200
            // 16 RAM (2) USD 900	USD 1000	 USD 1400
            // 32 RAM (3) USD 1000	USD 1400	 USD 2000
            // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

            int procesador, memoria, disco; 
            int precio = 0; 

            Console.WriteLine("Ingrese el procesador: "); 
            procesador = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese la memoria memoria: "); 
            memoria = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese si quiere extender el disco "); 
            disco = int.Parse(Console.ReadLine()); 

            //HECHO POR MAXI. 
            // if(procesador == 1 && memoria == 1)
            //     precio = 800; 
            // else if(procesador == 1 && memoria == 2)    
            //     precio = 900; 
            // else if(procesador == 1 && memoria == 3)     
            //     precio = 1000; 
            // else if(procesador == 2 && memoria == 1)
            //     precio = 900; 
            // else if(procesador == 2 && memoria == 2)
            //     precio = 1000; 
            // else if(procesador == 2 && memoria == 3)            
            //     precio = 1400; 
            // else if(procesador == 3 && memoria == 1)
            //     precio = 1200; 
            // else if(procesador == 3 && memoria == 2)    
            //     precio = 1400;
            // else if(procesador == 3 && memoria == 3)    
            //     precio = 2000; 
            // if(disco == 1)
            //    precio += 300; 

            // Console.WriteLine("El resultado es: " + precio); 


            // HECHO POR MI PERO CON AYUDA DE MAXI.    
            switch(procesador){ 
                case 1: 
                    switch(memoria)
                    { 
                    case 1: 
                        precio = 800;  
                    break; 
                    case 2: 
                        precio = 900; 
                    break;  
                    case 3:
                        precio = 1000; 
                    break; 
                    }
                break; 
                case 2: 
                    switch(memoria)
                    { 
                    case 1: 
                       precio = 900;  
                    break; 
                    case 2: 
                       precio = 1000; 
                    break;  
                    case 3:
                       precio = 1400; 
                    break; 
                    } 
                break;    
                case 3: 
                    switch(memoria)
                    { 
                    case 1: 
                       precio = 1200;  
                    break; 
                    case 2: 
                       precio = 1400; 
                    break;  
                    case 3:
                       precio = 2000; 
                    break; 
                    }    
                break;           
            }
            
            if(disco == 1){ 
                precio = precio + 300;  
            }
            else{ 
            Console.WriteLine("No extiende disco"); 
            }
            
            Console.WriteLine("Total de la compra: " + precio); 
        }
    }
}
