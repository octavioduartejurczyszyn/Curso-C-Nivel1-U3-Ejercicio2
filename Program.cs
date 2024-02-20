using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” 
         //si el número es mayor a cero,
         // “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
         //if(n > 0)
              //  System.Console.WriteLine("Positivo");
             //if(n < 0)
              // System.Console.WriteLine("Negativo");
             //if(n == 0)
              //  System.Console.WriteLine("Cero");

            int n;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            if(n > 0)
                System.Console.WriteLine("Positivo");
            else if(n < 0)
                System.Console.WriteLine("Negativo");
            else
                System.Console.WriteLine("Cero");
            
            
        }       
       
    }       
}
