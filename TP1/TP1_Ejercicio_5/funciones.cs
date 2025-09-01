using System;
using System.Threading;

namespace Funciones
{
    internal class funciones
    {
        public static void saludo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bienvenido al sistema de funciones");
        }

        public static void suma(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("La suma es: " + (a + b));
        }

        public static int aleatorio()
        {
            Random numero = new Random();
            
            return numero.Next(1, 101);
        }

        public static int cuadrado(int numero)
        {
            return numero * numero;
        }
    }
}
