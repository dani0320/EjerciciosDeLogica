using System;

namespace unidad_8_end
{
    class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONES
            // PARTES DE LA FUNCION 
            // CABECERA
            // 1. TIPO DE DATO
            // 2. NOMBRE 
            // 3. OPCIONAL: PARAMETROS 
            // CUERPO 
            // DEFINICION/LOGICA 
            // OPCIONAL: RETORNO DE VALOR/RESULTADO



            int n1 = 0, n2 = 0; //INICIALIZAR EN '0' PARA QUE EL COMPILADOR NO JODA. EN ESTE CASO POR PARAMETRO DE "REFERENCIA". 

            // Console.WriteLine("Ingrese el primer nro: "); 
            // n1 = int.Parse(Console.ReadLine()); 
            // Console.WriteLine("Ingrese el segundo nro: "); 
            // n2 = int.Parse(Console.ReadLine()); 

            pedirDatos( ref n1, ref n2); // <- PARAMETRO POR REFERENCIA. 
            
            int resultado = sumar(n1, n2); // <- PARAMETRO POR VALOR. 
            Console.WriteLine("El valor es: " + resultado); 

        // Console.WriteLine("Fin del programa " + devolverUno()); 
        }
        // static int devolverUno()
        // { 
        //     int numero = 22; 
        //     return numero; 
        // }

           
           //"PARAMETRO POR VALOR" :
           static int sumar(int n1, int n2)
           { 
            int r;   
            r = n1 + n2; 
            return r; 
           }


           //"PARAMETRO POR REFERENCIA" :
           static void pedirDatos(ref int j, ref int h)
           { 
            Console.WriteLine("Ingrese el primer nro: "); 
            j = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el segundo nro: "); 
            h = int.Parse(Console.ReadLine());
           }
    } 
}
