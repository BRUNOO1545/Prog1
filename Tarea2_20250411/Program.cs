using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea2_20250411
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea 2: Pedir al usuario que ingrese dos fraces, que el programa cuente la cantidad
			// de caracteres que tienen e indique cual de ellas es la mayor

			// Setup console
			Console.Title = "Comparar textos";
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Clear();

			// Program itself
			Console.WriteLine("Bienvenido al comparador de textos");

			string texto_1, texto_2;
			Console.Write("\nIngrese un primer texto, al terminar presione ENTER: ");
			texto_1 = Console.ReadLine();

			Console.Write("\nIngrese un segundo texto, al terminar presione ENTER: ");
			texto_2 = Console.ReadLine();

			int cantidad_texto_1, cantidad_texto_2;
			cantidad_texto_1 = texto_1.Length;
			cantidad_texto_2 = texto_2.Length;

			if (cantidad_texto_1 > cantidad_texto_2)
				Console.WriteLine("El primer texto es mayor. [" + texto_1 + "].");
			else
				Console.WriteLine("El segundo texto es mayor. [" + texto_2 + "].");

			Thread.Sleep(10000);
		}
	}
}
