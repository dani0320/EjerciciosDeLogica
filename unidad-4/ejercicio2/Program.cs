using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
                //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
                //Si vende menos de 100 litros, no hay descuento.
                //Si vende entre 101 y 300 litros, el descuento es del 10%.
                //Si vende entre 301 y 500 litros, el descuento es del 15%.
                //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
                //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita    el  importe con el descuento aplicado..

                float litros, importeTotal, importeFinal = 0; 

                Console.WriteLine("Ingrese el importe"); 
                importeTotal = float.Parse(Console.ReadLine()); 
                Console.WriteLine("Ingrese la cantidad de litros vendidos: "); 
                litros = float.Parse(Console.ReadLine()); 

                if(litros < 100){ 
                    importeFinal = importeTotal; 
                }else if(litros > 100 && litros <= 300){ 
                    importeFinal = importeTotal * 0.90F; 
                }else if(litros > 300 && litros <= 500){ 
                    importeFinal = importeTotal * 0.85F; 
                }else if(litros > 500){
                    importeFinal = importeTotal * 0.75F; 
                }
                Console.WriteLine("El resultado final es: " + importeFinal); 

                // if(litros >= 101){ 'HECHO POR MI'
                //     if(litros <= 300) 
                //     importeFinal = importeTotal * 0.90F; 
                //     Console.WriteLine("El descuento es del 10%: " + litros); 
                // }
                // if(litros >= 301){ 
                //    if(litros <= 500) 
                //    importeFinal = importeTotal * 0.85F;  
                //    Console.WriteLine("El descuento es del 15%: " + litros); 
                // }
                // else if(litros >= 500){ 
                //    Console.WriteLine("El descuento es del 25%: " + litros); 
                //    importeFinal = importeTotal * 0.75F; 
                // }
                
                // Console.WriteLine("El resultado es: " + importeTotal); 

                
                
                
                
                // float litros, importeTotal, importeFinal = 0; 'HECHO POR CHATGPT'

                // Console.WriteLine("Ingrese el importe total de la venta: ");
                // importeTotal = float.Parse(Console.ReadLine());

                // Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
                // litros = float.Parse(Console.ReadLine());

                // if (litros >= 101 && litros <= 300)
                // {
                //  importeFinal = importeTotal * 0.90F;
                //  Console.WriteLine("El descuento es del 10%: " + litros);
                // }
                // else if (litros >= 301 && litros <= 500)
                // {
                // importeFinal = importeTotal * 0.85F;
                // Console.WriteLine("El descuento es del 15%: " + litros);
                // }
                // else if (litros > 500)
                // {
                // importeFinal = importeTotal * 0.75F;
                // Console.WriteLine("El descuento es del 25%: " + litros);
                // }

                // Console.WriteLine("El resultado es: " + importeFinal);


                


        }
    }
}
