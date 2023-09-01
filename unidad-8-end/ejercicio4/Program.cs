using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.

            // int posi = 0, neg = 0, cero = 0; 
            int status = 10, n1; 

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese los numeros: "); 
                n1 = int.Parse(Console.ReadLine()); 

                positivoNegativoCero(n1, ref status);
                Console.WriteLine("El estado del valor " + n1 + " es: " + status); 
            }

        }
        static void positivoNegativoCero(int n1, ref int f)
        { 
            if(n1 == 0)
                f = 0; 
            else if(n1 > 0)
                f = 1; 
            else
                f = -1; 
        }

    }
}
