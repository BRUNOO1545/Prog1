using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250411
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea  1: Desarollara un programa que le pida al usuario
			// dos valores numericos enteros y devuelva un mensaje diciendo cual de ellos es el mayor,
			// y en caso de ser iguales dar o mostrar solamente el mensaje "ambos son iguales!!".

			// setup console
			Console.Title = "Comparar numeros";
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Clear();

			// program itself
			int numero_1, numero_2;

			Console.WriteLine("Bienvenido a la comparativa numero 1 de latinoamerica");

			Console.Write("\nIngrese un primer valor: ");
			numero_1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nIngrese un segundo valor: ");
			numero_2 = Convert.ToInt32(Console.ReadLine());

			if (numero_1 == numero_2)
			{
				Console.WriteLine("Ambos son iguales!!");
			}
			else
			{
				if (numero_1 > numero_2)
				{
					Console.WriteLine("El primer valor (" + numero_1 + ") es mayor.");
				}
				else
				{
					Console.WriteLine("El segundo valor (" + numero_2 + ") es mayor.");
				}
			}

			Thread.Sleep(9000);
		}
	}
}
