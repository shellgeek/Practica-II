/* 
Escriba un programa que solicite la edad del usuario y evalúe si es un niño, un adolescente, un
adulto joven, de mediana edad o un adulto mayor (rangos aleatorios)
EJEMPLO:
Niños (0 – 10)
Adolescentes (11 – 17)
Adulto joven (18 – 38)
Mediana Edad (39-59)
Adulto mayor (60 – 99)
AUTOR: RAINIER L. DE JESUS LOPEZ 
*/

using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad; string mensaje="";
            // CAPTURA DE DATO
            Console.WriteLine("***** Evaluar la Edad de una Persona *****");
            Console.WriteLine("Ingresa tu edad...:");
            edad=int.Parse(Console.ReadLine());
            //CONDICIONALES
            if (edad>=0 && edad<=10){mensaje="Eres un Niño!!!";}
                else if (edad>=11 && edad<=17){mensaje="Eres un Adolescente!!!";}
                    else if (edad>=18 && edad<=38){mensaje="Eres un Adulto Joven!!!";}
                        else if (edad>=39 && edad<=59){mensaje="Eres Adulto de Mediana Edad!!!";}
                            else if (edad>=60 && edad<=99){mensaje="Eres un Adulto Mayor!!!";}
                                else {mensaje="Ohhh felicidades!!!";}
            //SALIDA DE DATO
            Console.WriteLine(mensaje);
        
        }
    }
}
