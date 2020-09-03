/* Escriba un programa que evalúe un numero ingresado por teclado, y muestre por pantalla si es
par o impar.
AUTOR: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant =0;
            Console.WriteLine ("***** Evalua si un Numero es Par o Impar ******");
            Console.Write("Ingresa una cantidad a evaluar...:");
            cant=Convert.ToInt16(Console.ReadLine());

            if (cant%2==0){Console.Write("El numero " + cant + " Es Par!!!");}
                else {Console.Write("El numero " + cant + " Es Impar!!!");}
        }
    }
}
