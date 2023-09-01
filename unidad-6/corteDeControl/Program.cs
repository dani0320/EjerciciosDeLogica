using System;

namespace corteDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //CORTE DE CONTROL 
            int legajo, edad, codigoEquipos; 
            float sueldo; 
            int equipoActual; 


            Console.WriteLine("Ingrese el legajo: "); 
            legajo = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese la edad: "); 
            edad = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el codigo del equipo: ");
            codigoEquipos = int.Parse(Console.ReadLine()); 

            while (sueldo > 0)
            {   equipoActual = codigoEquipos; 
                while (codigoEquipos == equipoActual)
                {
                    Console.WriteLine("Ingrese el legajo: "); 
                    legajo = int.Parse(Console.ReadLine()); 
                    Console.WriteLine("Ingrese la edad: "); 
                    edad = int.Parse(Console.ReadLine()); 
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = float.Parse(Console.ReadLine()); 
                    Console.WriteLine("Ingrese el codigo del equipo: ");
                    codigoEquipos = int.Parse(Console.ReadLine());
                }
            }


        }
    }
}
