using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int[] vAcu = new int [15]; 
            int nroArticulo, canVendi; 
            for (int x = 0; x < 15; x++)
            {
                vAcu[x] = 0; 
            }

            Console.WriteLine("Ingrese el nro de articulo ");
            nroArticulo = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese la cantidad vendida: "); 
            canVendi = int.Parse(Console.ReadLine()); 

            while (nroArticulo != 0)
            {
                vAcu[nroArticulo -1 ] += canVendi; 
                Console.WriteLine("Ingrese el nro de articulo ");
                nroArticulo = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Ingrese la cantidad vendida: "); 
                canVendi = int.Parse(Console.ReadLine());   

            }
            
            //PUNTO A  
            int max = vAcu[0]; 
            int diosmio = 1; 
            for (int x = 0; x < 15; x++)
            {
                if(vAcu[x] > max)
                { 
                    max = vAcu[x]; 
                    nroArticulo = x + 1; 
                }
            }
            Console.WriteLine("El articulo donde más se vendio fué: " + nroArticulo + " Y la cantidad total: " + max); 

            //PUNTO B: 
            for (int x = 0; x < 15; x++)
            {
                if(vAcu[x] == 0)
                {     
                   Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas" ); 
                } 
            }

            //FALTA PUNTO C: 
                    Console.WriteLine("En la unidad 10 se vendieron en total: " + vAcu[9]); 
        }
    }
}
