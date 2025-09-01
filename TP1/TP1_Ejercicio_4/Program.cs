using System;
using System.Threading;

namespace TP1_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

			Enunciado: Simular un carrito de compras para un comercio. El programa debe permitir al usuario ingresar productos 
            (nombre y precio) hasta que decida salir. Luego debe mostrar el listado de productos y el total a pagar.

			Objetivo: Usar estructuras while, do while, y control de errores con try-catch.

			Reglas:
				- Si el empleado trabajó más de 40 horas, las horas extras se pagan al 50% más del valor por hora.
				- El programa debe calcular el total a cobrar y mostrar un resumen en pantalla.

			Requisito técnico:
                - Usar do-while para permitir al usuario seguir ingresando productos.
                - Usar while para validar que el precio ingresado sea válido (positivo).
                - Usar try-catch para capturar errores al ingresar el precio.
                - Al ingresar un producto con nombre “fin” se detiene el ingreso (break).
                - Si el precio es 0 o negativo, volver a pedirlo (continue).

			*/

            bool error;
            string op = "";
            string productoNombre = "";
            double productoPrecio = 0f;
            double totalPago = 0f;

            List<(string nombre, double precio)> productos = new List<(string nombre, double precio)>();

            do
            {
                error = true;

                while (error)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el nombre del producto (o escriba ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'fin'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" para terminar): ");
                    productoNombre = Console.ReadLine();

                    if (String.IsNullOrEmpty(productoNombre))
                    {
                        Console.Write("\nError ingrese un nombre valido.\n");
                    }
                    else
                    {
                        error = false;
                    }
                }

                if (productoNombre == "fin")
                {
                    break;
                }

                error = true;

                while (error)
                {
                    try
                    {
                        Console.Write("Ingrese el precio: ");
                        productoPrecio = Convert.ToDouble(Console.ReadLine());

                        if (productoPrecio <= 0)
                        {
                            Console.Write("\nError ingrese un precio valido.\n");
                        }
                        else
                        {
                            error = false;
                        }
                    }
                    catch
                    {
                        Console.Write("\nError ingrese un número valido.\n");
                    }
                }

                productos.Add((nombre: productoNombre, precio: productoPrecio));

                error = true;

                while (error)
                {
                    Console.Write("\n¿Desea ingresar otro producto? (s/n): ");
                    op = Console.ReadLine();
                    
                    if (String.IsNullOrEmpty(op))
                    {
                        Console.Write("\nError ingrese un opción.\n");
                    }
                    else if (!(op.ToLower() == "n" || op.ToLower() == "s"))
                    {
                        Console.Write("\nError ingrese una opción valida.\n");
                    }
                    else
                    {
                        error = false;
                    }
                }
            } while (op != "n");

            Console.Write("\nLista de productos:\n");

            foreach(var producto in productos)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("- " + producto.nombre + ": ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("$" + producto.precio + "\n");

                totalPago += producto.precio;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Total a pagar: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("$" + totalPago);

            Thread.Sleep(10000);
        }
    }
}