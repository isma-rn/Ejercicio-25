using System;
using System.Text.RegularExpressions;

namespace E25_Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;            
            string opcion, year;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Programa que valida si un año es bisiesto");
                Console.WriteLine("Ingrese el año:");
                year = Console.ReadLine();
                if (ValidarYear(year))                
                    Console.WriteLine("{0} {1} bisiesto", year, EsBisiesto(Int32.Parse(year)) ? "es" : "no es");                
                else
                    Console.WriteLine("Error, año no válido");

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);
        }
        public static bool EsBisiesto(int year)
        {
            if ( year % 4 == 0 && (year % 100 != 0 || year % 400 == 0 ) )
                return true;
            return false;
        }
        public static bool ValidarYear(string cadena)
        {
            cadena = cadena.TrimStart();
            Regex patron = new Regex("^[\\d\\d?\\d?\\d?]");
            return patron.IsMatch(cadena);
        }
    }
}
