using System;

namespace unidad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // int facturado; 
            // int[] numeros = new int[10]; 

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un nro "); 
            //     facturado = int.Parse(Console.ReadLine()); 
            //     numeros [x] = facturado; 
            // }

            // int acu = 0; 
            // for (int x = 0; x < 10; x++)
            // {
            //     acu += numeros[x]; 
            //     Console.WriteLine("El valor es: " + numeros[x]);
            // }
            // int promedio = acu / 10; 

            // double[]muestraMatutina = new double[31]; 
            // double[]muestraVespertina = new double[31]; 
            // double[]muestraNocturna = new double[31]; 

            // int dia; 
            // double temperatura; 
            // Console.WriteLine("Cargue el registro matutino"); 
            
            // for (int x = 0; x < 31; x++)
            // {
            //     Console.WriteLine("Ingrese el dia: "); 
            //     dia = int.Parse(Console.ReadLine());
            //     if(dia == 0)    
            //     { 
            //         break; //SALIR PROGRAMA.
            //     }
                     
            //     Console.WriteLine("Ingrese la temperatura: "); 
            //     temperatura = double.Parse(Console.ReadLine()); 

            //     muestraMatutina[dia-1] = temperatura;
                
            // }

            
            
            
            //CADENA DE CARACTERES: 

            // char[] nombre = new char [24]; 

            // char  letra; 
            // int indice = 0; 

            // Console.WriteLine("Ingrese su nombre letra por letra (Cortar con punto): "); 
            // letra = char.Parse(Console.ReadLine()); 

            // while (letra != '.' && indice < 24)
            // {
            //     nombre[indice] = letra; 
            //     letra = char.Parse(Console.ReadLine()); 
            //     indice++; 

            // }
            // nombre[indice] = '\0';

            // // Console.WriteLine("Hola" + nombre);     

            // Console.Write("Hola "); 
            // indice = 0; 
            // while (nombre[indice] != '\0')
            // {
            //     Console.Write( nombre[indice] ); 
            //     indice++; 
            // }





            //TIPO DE DATO STRING (TEXTO). 
            string nombre;
            Console.WriteLine("Ingrese su nombre: "); 
            nombre = Console.ReadLine(); 

            Console.Write("Su nombre es: " + nombre); 
        }
    }
}
