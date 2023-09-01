using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // char letra = 'A'; 

            // Console.WriteLine("Ingrese algo: "); 
            // letra = char.Parse(Console.ReadLine()); 

            // switch(letra){ 
            //     case 'M': 
            //     Console.WriteLine("Tu nombre empieza en M..."); 
            //     break; 
            //      case 'H': 
            //     Console.WriteLine("Es incorrecto"); 
            //     break;
            //      case 'R': 
            //     Console.WriteLine("Es incorrecto"); 
            //     break;
            //     default: 
            //     Console.WriteLine("No coincide ninguna"); 
            //     break; 

            // }

            // Console.WriteLine("FIN DEL PROGRAMA... ");


                  //EJERCICIO 1: 
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //    La resta si el primero es mayor que el segundo.
            //    La suma si son iguales.
            //    El producto si el primero es menor.
            //    Se deberá emitir un cartel por pantalla con el resultado correspondiente. 

                  // int n1, n2, resultado; 

                  // Console.WriteLine("Ingrese el primer numero: "); 
                  // n1 = int.Parse(Console.ReadLine()); 
                  // Console.WriteLine("Ingrese el segundo numero: "); 
                  // n2 = int.Parse(Console.ReadLine()); 

                  // if(n1 > n2)
                  //   resultado = n1 - n2; 
                  // if(n1 == n2)  
                  //   resultado = n1 + n2;
                  // if(n1 < n2)
                  //   resultado = n1 * n2;  
                    
                  // Console.WriteLine("El resultado es: " + resultado);

 
                  int n1, n2, resultado;
        
                  Console.WriteLine("Ingrese el primer número: ");
                  n1 = int.Parse(Console.ReadLine());
        
                  Console.WriteLine("Ingrese el segundo número: ");
                  n2 = int.Parse(Console.ReadLine());

                  if (n1 > n2)
                  {
                        resultado = n1 - n2;
                        Console.WriteLine("La resta es: " + resultado);
                  }
                  else if (n1 == n2)
                  {
                        resultado = n1 + n2;
                        Console.WriteLine("La suma es: " + resultado);
                  }
                  else
                  {
                        resultado = n1 * n2;
                        Console.WriteLine("El producto es: " + resultado);     
                  }
                
        }
    }
}
