/*
Escriba un programa que dado un monto disponible de RD$18,765.43 pesos, pueda realizar
retiros. El monto del retiro lo ingresará el usuario por teclado. El sistema debe evaluar si el
monto solicitado se puede retirar (si el retiro excede al monto disponible, no se puede hacer el
retiro) Al final debe mostrar por pantalla el monto disponible después del retiro
AUTOR: RAINIER L. DE JESUS LOPEZ 
*/

using System;

namespace p5
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance=18765.43,retiro, deposito;
            int opt=0;
            Menu:
            string resp="";
            Console.Clear();
            Console.WriteLine("********** SIMULACION CAJERO BANCARIO **********\n");
            Console.WriteLine("[1] - DEPOSITO");
            Console.WriteLine("[2] - RETIRO");
            Console.WriteLine("[3] - CONSULTA DE BALANCE");
            Console.WriteLine("[4] - SALIR\n");
            Console.Write("SELECCIONE UNA OPERACION A REALIZAR [1],[2],[3],[4]...:");
            opt=int.Parse(Console.ReadLine());
            switch(opt)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("\n********* DEPOSITO DE EFECTIVO **********\n");
                Console.Write("INGRESE EL MONTO A DEPOSITAR...:");
                deposito=double.Parse(Console.ReadLine());
                Console.WriteLine("\n---> DEPOSITANDO UN TOTAL DE RD${0} <---",deposito);
                balance=balance+deposito;
                Console.WriteLine("\n---> SU NUEVO BALANCE ES DE RS${0} <---\n",balance );
                Console.WriteLine("********** TRANSACCION COMPLETA **********");
                Console.Write("\nPRESIONE [INTRO - ENTER] PARA REGRESAR AL MENU, ó [S] PARA SALIR...:");
                
                resp=Console.ReadLine();
                if(resp=="S"||resp=="s"){Environment.Exit(0);}
                    else {goto Menu;}
                break;

                case 2:
                Console.Clear();
                Console.WriteLine("\n***** RETIRO DE EFECTIVO *****\n");
                Console.Write("INGRESE EL MONTO A RETIRAR...:");
                retiro=double.Parse(Console.ReadLine());
                if (balance>retiro){
                Console.WriteLine("\n--> RETIRANDO UN TOTAL DE RD$"+retiro+ " <--");
                balance=balance-retiro;
                Console.WriteLine("\nSU NUEVO BALANCE ES DE RS${0}",balance );
                Console.WriteLine("\n***** TRANSACCION COMPLETA *****\n");}
                else{Console.WriteLine("BALANCE INSUFICIENTE, INTENTE CON UN MONTO MENOR");}
                Console.Write("\nPRESIONE [INTRO - ENTER] PARA REGRESAR AL MENU, ó [S] PARA SALIR...:");
                resp=Console.ReadLine();
                if(resp=="S"||resp=="s"){Environment.Exit(0);}
                    else {goto Menu;}
                break;

                case 3:
                Console.Clear();
                Console.WriteLine("\n********** CONSULTA DE BALANCE **********\n");
                Console.WriteLine("---> SU BALANCE ES DE RD$ {0} <---\n",balance);
                Console.WriteLine("********** TRANSACCION COMPLETA **********\n");
                Console.Write("\nPRESIONE [INTRO - ENTER] PARA REGRESAR AL MENU, ó [S] PARA SALIR...:");
                resp=Console.ReadLine();
                if(resp=="S"||resp=="s"){Environment.Exit(0);}
                    else {goto Menu;}
                break;
                case 4:
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("HA SELECCIONADO UNA OPCION INVALIDA");
                break;

            }



        }
    }
}
