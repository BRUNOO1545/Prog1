using System;
using System.Threading;
using Funciones;

namespace TP1_Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

			Enunciado: Crear un programa de consola que implemente las siguientes funciones:
                - Una función que no recibe ni devuelve valores: Muestra un mensaje de bienvenida al sistema.
                - Una función que recibe dos números enteros pero no devuelve valor: Muestra la suma de ambos.
                - Una función que no recibe nada pero devuelve un número entero: Devuelve un número aleatorio entre 1 y 100.
                - Una función que recibe un número entero y devuelve su cuadrado.

			Objetivo: Comprender el uso de funciones con y sin parámetros, con y sin retorno.

			Reglas:
				- Si el empleado trabajó más de 40 horas, las horas extras se pagan al 50% más del valor por hora.
				- El programa debe calcular el total a cobrar y mostrar un resumen en pantalla.

			Requisito técnico: En el Main() debe llamarse a todas las funciones, mostrar los resultados donde corresponda, 
            y comentar el comportamiento de cada una.

			*/

            // saludar y presentar al usuario
            funciones.saludo();

            // pedir los numeros
            int numero_1, numero_2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nIngrese dos valores ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("para sumar:\n");
            numero_1 = Convert.ToInt32(Console.ReadLine());
            numero_2 = Convert.ToInt32(Console.ReadLine());

            // sumar los valores ingresados y mostrar en pantalla
            funciones.suma(numero_1, numero_2);

            // generar un numero aleatorio
            int numeroAleatorio = funciones.aleatorio();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nGenerando número aleatorio...");
            Console.Write("\n\nEl numero ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("generado es: " + numeroAleatorio);


            // elevar un numero al cuadrado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nIngrese un número ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("para elevar al cuadrado:\n");
            int numeroCuadrado = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEl cuadrado es: " + funciones.cuadrado(numeroCuadrado));

            Thread.Sleep(10000);
        }
    }
}