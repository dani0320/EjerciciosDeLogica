using System;

namespace aplicarTodosLosEjem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1; 
            Console.WriteLine("Ingresar el numero: "); 
            n1 = int.Parse(Console.ReadLine()); 
            while (n1 != 0)
            {
                n1 = int.Parse(Console.ReadLine()); 
            }

            bool rta = TodasLasfunciones(n1); 
            Console.WriteLine("Los resultados son los siguientes: " + rta); 
        }
        static bool TodasLasfunciones(int n1)
        {   int conPares = 0, acupar = 0; 
            int conImpares = 0; 
            if(n1 % 2 == 0)
            { 
                return true;
                conPares++; 
            }
            else
            { 
                return false; 
                conImpares++; 
            } 

        }



    }
}
