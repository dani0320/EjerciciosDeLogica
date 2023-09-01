using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"
                    //FRASE 
            // char[] caracter = new char[30]; 
            // char letra; 
            // int indice = 0; 

            string frase; 
            char letraActual, letraNueva; 
            Console.WriteLine("Ingrese la frase: "); 
            frase = Console.ReadLine(); 
            Console.WriteLine("Ingrese la letra a reemplazar: "); 
            letraActual = char.Parse(Console.ReadLine()); 
            Console.WriteLine("Letra a la que se va a cambiar: "); 
            letraNueva = char.Parse(Console.ReadLine()); 

            frase = frase.Replace(letraActual, letraNueva);
            
            Console.WriteLine("La cadena nueva es: "); 
            Console.WriteLine(frase); 

            
            // Console.WriteLine("Ingrese una letra (punto para terminar programa): ");  
            // letra = char.Parse(Console.ReadLine());     

            // indice = 0; 
            // while (letra != '.' && indice < 30)
            // {
            //     caracter[indice] = letra; 
            //     indice++; 
            //     letra = char.Parse(Console.ReadLine());
            // }

            // // caracter[indice] = '\0'; 
            // // indice = 0; 
            // for (int x = 0; x < 30; x++)
            // {
            //     if(caracter[x] == 'a')
            //         caracter[x] = 'i'; 
            // }
            
            // indice = 0; 
            // //mostrar resultado: 
            // for (int x = 0; x < 30; x++)
            // {
            //     Console.Write("Resultado final: " + caracter[x]); 
            //     indice++; 
            // }

            // char letraActual, letraNueva; 

            // Console.WriteLine("Ingrese una letra (punto para terminar programa): ");  
            // letra = char.Parse(Console.ReadLine());
            // while (letra != '.' && indice < 30)
            // {
            //     caracter[indice] = letra; 
            //     indice++; 
            //     letra = char.Parse(Console.ReadLine());
            // }

            // caracter[indice] = '\0'; 
            // Console.WriteLine("La frase completa es: "); 
            // indice++; 
            // while (caracter[indice] != '\0')
            // {
            //     Console.Write(caracter[indice]); 
            //     indice++; 
            // }
            
            // Console.WriteLine("Ingrese la letra a reemplazar: "); 
            // letraActual = char.Parse(Console.ReadLine()); 
            // Console.WriteLine("Letra a la que cambiara: "); 
            // letraNueva = char.Parse(Console.ReadLine()); 
            
            // indice = 0; 
            // while (caracter[indice] != '\0')
            // {
            //     if(caracter[indice] == letraActual)
            //         caracter[indice] = letraNueva; 
            //     indice++;     
            // }
            // Console.WriteLine("La frase nueva es: "); 
            // indice = 0; 
            // while (caracter[indice] != '\0')
            // {
            //     Console.Write(caracter[indice]); 
            //     indice++; 
            // }
        }
    }
}
