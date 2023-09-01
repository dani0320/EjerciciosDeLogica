using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados //. 
            // ejercicio 3 - unidad 2 // 

            float c1, veh, c2; 

            Console.WriteLine("Ingresar los Kilometros"); 
            c1 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("Velociad del vehiculo"); 
            veh = float.Parse(Console.ReadLine()); 

            c2 = c1 / veh; 
            Console.WriteLine("Tiempo de demora: " + c2.ToString("0.0") + " horas"); 
        }
    }
}
