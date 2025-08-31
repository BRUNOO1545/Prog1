using System;
using System.Threading;

namespace TP1_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

			 Enunciado: Crear un programa que calcule el sueldo semanal de un empleado. El usuario debera ingresar:
				- Nombre del empleado (dato tipo string).
				- Cantidad de horas trabajadas en la semana (dato tipo int).
				- Pago por hora (dato tipo double).

			 Objetivo: Aplicar operaciones aritméticas, condicionales y uso de variables.

			 Reglas:
				- Si el empleado trabajó más de 40 horas, las horas extras se pagan al 50% más del valor por hora.
				- El programa debe calcular el total a cobrar y mostrar un resumen en pantalla.

			Requisito técnico:
				- Uso de constantes (por ejemplo, porcentaje extra).
				- Uso de operaciones aritmétricos, relacionales, condicional sentencias if.
				- Mostrar resultado por consola.

			*/

            string nombreEmpleado;
            int horasTrabajadas, horasNormales, horasExtra;
            double valorPorHora, totalACobrar;
            horasExtra = 0;
            horasNormales = 40;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ingrese el nombre del empleado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            nombreEmpleado = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ingrese las horas trabajadas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor por hora: ");
            valorPorHora = Convert.ToDouble(Console.ReadLine());

            totalACobrar = horasTrabajadas * valorPorHora;

            if (horasTrabajadas > horasNormales)
            {
                horasExtra = horasTrabajadas - horasNormales;
                totalACobrar = (horasNormales * valorPorHora) + ((horasExtra * valorPorHora) * 1.50);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\nEmpleado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nombreEmpleado);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nHoras normales: ");
            Console.Write(horasNormales);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nHoras extra: ");
            Console.Write(horasExtra);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nTotal a cobrar: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$" + totalACobrar);

            Thread.Sleep(5000);
        }
    }
}