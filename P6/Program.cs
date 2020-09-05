/*Escriba un programa que solicite al usuario, cantidad de cuotas, y porcentaje de interés anual de
un préstamo, calcule y muestre en pantalla la cuota mensual. (Amortizar mediante el sistema
francés)
AUTOR RAINIER L. DE JESUS LOPEZ
*/
using System;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.Clear();
            float monto, tiempo, interes, cuota, interes_pagado,capital_pagado,i, fila,total_interes=0, total_pago=0;
            string resp="";
            Console.WriteLine("********** CALCULO DE PRESTAMO (METODO FRANCES) **********\n");
            Console.Write("INGRESE EL MONTO DEL PRESTAMO...:");
            monto=float.Parse(Console.ReadLine());
            Console.Write("INGRESE EL TIEMPO (MESES)...:");
            tiempo=float.Parse(Console.ReadLine());
            Console.Write("INGRESE EL % DE INTERES...:");
            interes=float.Parse(Console.ReadLine());
            interes=interes/100;

            cuota=interes+1;
            cuota=(float) Math.Pow(cuota,tiempo);
            cuota = cuota-1;
            cuota = interes/cuota;
            cuota = interes+cuota;
            cuota=monto*cuota;
            
            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("NUM. CUOTA \t");
            Console.Write("CUOTA \t\t");
            Console.Write("INTERESES PAGADOS \t\t");
            Console.Write("CAPITAL PAGADO \t\t");
            Console.Write("MONTO DEL PRESTAMO \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}",string.Format("{0:C2}", monto));

            for(i=1;i<=tiempo;i++)
            {
                Console.Write("{0}\t",fila);
                Console.Write("\t{0}\t\t",string.Format("{0:C2}",cuota));
                interes_pagado=interes*monto;
                Console.Write("{0}\t\t",string.Format("{0:C2}",interes_pagado));
                total_interes=total_interes+interes_pagado;
                capital_pagado=cuota-interes_pagado;
                Console.Write("\t{0}\t\t",string.Format("{0:C2}",capital_pagado));
                monto=monto-capital_pagado;
                monto.ToString("c2");
                Console.Write("\t{0}\t",string.Format("{0:C2}",monto));
                fila=fila+1;
                Console.WriteLine("\n");
            }
                Console.WriteLine("Total de Intereses pagados...:{0}", string.Format("{0:C2}",total_interes));
                
                Console.WriteLine("Total de Intereses + Capital...:{0}", string.Format("{0:C2}",total_pago));
                Console.Write("\nPRESIONE [INTRO - ENTER] PARA CALCULAR OTRO PRESTAMO, ó [S] PARA SALIR...:");
                resp=Console.ReadLine();
                if(resp=="S"||resp=="s"){Environment.Exit(0);}
                    else goto Start;
        }
    }
}
