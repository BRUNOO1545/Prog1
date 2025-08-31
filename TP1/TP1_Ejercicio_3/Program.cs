﻿using System;
using System.Threading;

namespace TP1_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

			 Enunciado: Crear un programa que muestre un menú de opciones para trabajar con un arreglo de números
			 enteros. El usuario podrá seleccionar entre:
				- Cargar el arreglo (ingresar 5 números enteros).
				- Mostrar los números usando foreach.
				- Calcular el promedio de los números.
				- Buscar un número (indicado por el usuario) y mostrar si está o no.
				- Salir.

			 Objetivo: Aplicar bucles (for, foreach), estructura switch y manejo de errores.

			 Reglas:
				- Si el empleado trabajó más de 40 horas, las horas extras se pagan al 50% más del valor por hora.
				- El programa debe calcular el total a cobrar y mostrar un resumen en pantalla.

			Requisito técnico:
				- Usar switch para manejar el menú.
				- Usar try-catch para validar entradas incorrectas (ej. letras en vez de números).
				- Incluir al menos un uso de continue y break dentro de los bucles.

			*/

            int opcion;
            bool error;

            do {
                error = true;
                opcion = 0;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("---- MENÚ ----");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n1. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Carga números");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n2. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Mostrar arreglo");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n3. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Calcular promedio");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n4. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Buscar número");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n5. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Salir");

                while (error)
                {
                    try
                    {
                        Console.Write("\nSeleccione una opción: ");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\n");
                        error = false;
                    }
                    catch
                    {
                        Console.Write("\nError Ingrese una opción valida.\n");
                    }
                }
            } while (opcion != 5);
        }
    }
}