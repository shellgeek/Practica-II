/*
Escriba un programa que muestre en pantalla dos opciones [s – sumar] [r – restar] el usuario
debe pulsar la tecla para la opción deseada, y debe ingresar el valor de dos números cuales
quiera para ver el resultado de la operación elegida
AUTOR: RAINIER L. DE JESUS LOPEZ 
*/

using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne=0, numTwo=0, resultado=0;
            string opt="";
            Console.WriteLine("***** CALCULADORA BASICA *****");
            Console.WriteLine("S - SUMAR");
            Console.WriteLine("R - RESTAR");
            Console.Write("SELECCIONE UNA OPERACION A REALIZAR S/R...:");
            opt=Console.ReadLine();
            Console.Write("Ingresa una cantidad...:");
            numOne=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa una cantidad...:");
            numTwo=Convert.ToInt32(Console.ReadLine());
                 if(opt=="S"||opt=="s"){resultado = numOne+numTwo;}
                    else if (opt=="R"||opt=="r"){resultado = numOne-numTwo;}
            Console.WriteLine("***** RESULTADO *****");
            Console.WriteLine("El resultado de la operación es...:{0}", resultado);
        }
    }
}
