/*
Almacene dos números y evalúe si el primero es mayor que el segundo. El resultado debe verse
en la consola
AUTOR: RAINIER L. DE JESUS LOPEZ 
*/
using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne, numTwo;
            string mensaje="";
            Console.WriteLine("***** EVALUAR SI ES CUAL NUMERO ES EL MAYOR *****");
            Console.Write("Ingresa una cantidad...:");
            numOne=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa una cantidad...:");
            numTwo=Convert.ToInt32(Console.ReadLine());

                if(numOne>numTwo) {mensaje=numOne + " Es mayor que " + numTwo;}
                    else if (numTwo>numOne) {mensaje=numTwo + " Es mayor que " + numOne;}
                        else {mensaje ="Ambas cantidades son iguales!";}
                    
            Console.WriteLine(mensaje);
        }
    }
}
