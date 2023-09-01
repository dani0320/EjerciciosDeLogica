using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //     El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //     Informar cuántos grupos están formados por todos números ordenados de mayor a menor. 

            int n1, conNumeros, conImpar, grupoMaxImpar = 0, min, conOrdenados = 0;  
            double imparPorcentaje, porcentajeMaximo = -1;
            bool banderaOrdenados; 

            for (int x = 0; x < 5; x++)
            {
                conNumeros = 0; 
                conImpar = 0; 
                banderaOrdenados = true; 
                Console.WriteLine("Ingrese un numero: "); 
                n1 = int.Parse(Console.ReadLine()); 
                min = n1; 

                while (n1 != 0)
                {
                    conNumeros++; 
                    if(n1 % 2 != 0)
                        conImpar++; 
                    //punto B
                    if(n1 <= min)
                        min = n1; 
                    else
                        banderaOrdenados = false; 
                    
                    n1 = int.Parse(Console.ReadLine()); 
                }
                    // REGLA DE TRES PARA PORCENTAJE
                    // conNumeros -> 100% 
                    // conImpar -> x=?

                imparPorcentaje = conImpar * 100 / conNumeros; 
                if(imparPorcentaje > porcentajeMaximo)
                { 
                    porcentajeMaximo = imparPorcentaje; 
                    grupoMaxImpar = x + 1; 
                }

                if(banderaOrdenados)
                    conOrdenados++; 
            }
            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoMaxImpar);
            Console.WriteLine("Los grupos formados de mayor a menor son: " + conOrdenados); 

        }
    }
}
