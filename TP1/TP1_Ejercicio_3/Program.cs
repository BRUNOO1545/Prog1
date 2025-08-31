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
            int[] numeros = new int[5];

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
                        error = false;
                    }
                    catch
                    {
                        Console.Write("\nError ingrese una opción valida.\n");
                    }
                }

                switch (opcion)
                {
                    case 1: // Cargar numeros
                        Console.Write("\nCargando números...\n");

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            error = true;

                            while (error)
                            {
                                try
                                {
                                    Console.Write("Ingrese el número " + (i + 1) + ": ");
                                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                                    error = false;
                                }
                                catch
                                {
                                    Console.Write("Error ingrese un número valido.\n");
                                }
                            }
                        }
                    break;

                    case 2: // Mostrar arreglo
                        Console.Write("\nMostrando números:\n");

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n- ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(numeros[i]);
                        }
                    break;

                    case 3: // Calcular promedio
                        Console.Write("\nEl promedio es: ");

                        int sumaNumeros = 0;

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            sumaNumeros += numeros[i];
                        }

                        Console.Write(sumaNumeros / numeros.Length);
                    break;

                    case 4: // Buscar numero
                        int busqueda = 0;
                        bool seEncuentra = false;

                        error = true;

                        while (error)
                        {
                            try
                            {
                                Console.Write("\nIngrese el número a buscar: ");
                                busqueda = Convert.ToInt32(Console.ReadLine());
                                error = false;
                            }
                            catch
                            {
                                Console.Write("\nError ingrese un número valido.\n");
                            }
                        }

                        foreach (int numero in numeros)
                        {
                            if (numero == busqueda)
                            {
                                seEncuentra = true;
                                break;
                            }
                        }

                        if (seEncuentra)
                        {
                            Console.Write("El número " + busqueda + " se encuentra en el arreglo.");
                        }
                        else
                        {
                            Console.Write("El número " + busqueda + " no se encuentra en el arreglo.");
                        }
                    break;

                    case 5: // Salir
                        Console.Write("\nSaliendo del programa...");
                        Thread.Sleep(5000);
                    break;

                    default:
                        Console.Write("\nError ingrese una opción valida.\n");
                    break;
                }

                Console.Write("\n\n");

            } while (opcion != 5);
        }
    }
}