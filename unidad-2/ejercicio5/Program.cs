using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final. // 
            // ejercicio 5 // 
            //                   COMO LO HABIA HECHO YO 

            // float notas, promedioFinal, n1; 
            // // float notas, n1; 

            // Console.WriteLine("Notas: "); 
            // n1 = float.Parse(Console.ReadLine()); 
            // // n1 = float.Parse(Console.ReadLine()); 


            // notas = n1 * 3 / 3; 
            // Console.WriteLine("Promedio final del alumno: " + notas); 

            // EXPLICADO POR MAXI: el aplico FLOAT y yo INT. 

            float n1, n2, n3, promedio; 

            Console.WriteLine("Nota uno: "); 
            n1 = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Nota dos: "); 
            n2 = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Nota tres: "); 
            n3 = float.Parse(Console.ReadLine()); 

            promedio = (n1 + n2 + n3) / 3; 

            Console.WriteLine("El promedio final es: " + promedio.ToString("0.00")); 




            //otro que hice xd. 
            int n1, n2, n3, promedio = 0, acu = 0, con = 0; 

            Console.WriteLine("Ingrese un numero: "); 
            n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese un numero: "); 
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: "); 
            n3 = int.Parse(Console.ReadLine());

            // promedio = (n1 + n2 + n3) / 3F; 
            // Console.WriteLine("El resultado es: " + promedio.ToString("0.00")); 

            if(n1 > 0)
            { 
                // promedio = (n1 + n2 + n3) / 3; 
                // Console.WriteLine("El resultado es: " + promedio); 
                acu = n1 + n2 + n3; 
                con = 3; 
                promedio = acu / con; 
                Console.WriteLine("El resultado es: " + promedio); 
            }

        }
    }
}
