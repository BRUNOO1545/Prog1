using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250523
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea: Hacer que el usuario escriba una frase y que luego ingrese 2 letras a buscar en la frase usando foreach.

			string frase;
			char letra_1 = ' ';
			char letra_2 = ' ';

			int contadorLetra_1 = 0;
			int contadorLetra_2 = 0;

			bool error = true;

			// frase
			do
			{
				Console.Write("Ingrese una frase: ");
				frase = Console.ReadLine();

				if (frase.Trim().Length > 0)
				{
					error = false;
				}
				else
				{
					Console.WriteLine("\nError, ingrese una frase valida...\n");
				}
			} while (error);

			// letra 1
			error = true;

			do
			{
				try
				{
					Console.Write("\nIngrese una primer letra para buscar: ");
					letra_1 = Convert.ToChar(Console.ReadLine().ToLower());

					error = false;
				}
				catch
				{
					Console.Write("\nError al ingresara el caracter, intente denuevo...\n");
				}
			} while (error);


			// letra 2
			error = true;

			do
			{
				try
				{
					Console.Write("\nIngrese una segunda letra para buscar: ");
					letra_2 = Convert.ToChar(Console.ReadLine().ToLower());

					error = false;
				}
				catch
				{
					Console.Write("\nError al ingresara el caracter, intente denuevo...\n");
				}
			} while (error);

			foreach (char caracter in frase)
			{
				if (char.ToLower(caracter) == letra_1) contadorLetra_1++;

				if (char.ToLower(caracter) == letra_2) contadorLetra_2++;
			}

			Console.WriteLine("\n\nLa cantidad total de letras \"" + letra_1 + "\" fueron " + contadorLetra_1 + "\nLa cantidad total de letras \"" + letra_2 + "\" fueron " + contadorLetra_2);
			Console.WriteLine("\nPresione cualquier tecla para cerrar...");

			Console.ReadKey();

			Console.Clear();
			Console.WriteLine("Hasta luego...");

			Thread.Sleep(2000);
		}
	}
}
