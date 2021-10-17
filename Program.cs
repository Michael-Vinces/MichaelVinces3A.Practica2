using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelVinces3A.Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuActivo = true;
            while (menuActivo)
            {
                menuActivo = MenuBasico();
            }
            Console.ReadKey();
        }
        private static bool MenuBasico()
        {
            Console.WriteLine("--------| PRÁCTICA 2 |--------");
            Console.WriteLine("Programas elaborados por Michael Vinces Andrade<\n");
            Console.WriteLine("01. El Mayor de dos números");
            Console.WriteLine("02. Par o Impar");
            Console.WriteLine("03. El mayor de tres números");
            Console.WriteLine("04. ");
            Console.WriteLine("05. Suma de 5 números");
            Console.WriteLine("06. Suma de los números deseados");
            Console.WriteLine("07. Tipo de triángulo");
            Console.WriteLine("08. Múltiplos del 7 del 1 al 100");
            Console.WriteLine("09. Promedio de los números ingresados");
            Console.WriteLine("10. Factorial");
            Console.WriteLine("11. Salir");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Elija la opción que quiera procesar");
            Console.WriteLine("________________________________________________");
            string opcion = Console.ReadLine();
            Console.Clear();
            if (opcion == "1")
            {
                Console.WriteLine("Programa 1");
                Console.WriteLine("*************************************************");
                Console.WriteLine("**************                       ************");
                Console.WriteLine("*************************************************");

                Console.WriteLine("\nPresione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();

                return true;
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Programa 2");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********                                 ********");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("\nPresione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Programa 3");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*****************                 ***************");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Programa 4");
                Console.WriteLine("*************************************************");
                Console.WriteLine("**************                       ************");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "5")
            {
                Console.WriteLine("Programa 5");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*******                                  ********");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "6")
            {
                Console.WriteLine("Programa 6");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*********                              **********");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "7")
            {
                Console.WriteLine("Programa 7");
                Console.WriteLine("*************************************************");
                Console.WriteLine("***********                             *********");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "8")
            {
                Console.WriteLine("Programa 8");
                Console.WriteLine("*************************************************");
                Console.WriteLine("************                         ************");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "9")
            {
                Console.WriteLine("Programa 9");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********                               **********");
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "11")
            {
                Console.WriteLine("Gracias por usar mi Programa...\nMichael Vinces Andrade te agradece... :)");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
            else if (opcion == "10")
            {
                Console.WriteLine("Programa 10");                          
            }
            Console.ReadLine();
            Console.Clear();
            return false;

        }

    }
}
