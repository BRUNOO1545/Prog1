using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250425
{
	class Program
	{
		static void Main(string[] args)
		{
			string opcion, input;

			Console.Write("Cuenta caracteres...\n\nOpciones:\n");
			Console.WriteLine("\tA- Ingresa una frase de no más de 50 caracteres.\n\tB- Ingresa una palabra de no mas de 10 caracteres.");

			Console.Write("\n\nQue desea hacer?:");
			opcion = Console.ReadLine();
			
			if (opcion == "A")
			{
				Console.Write("\n\nLa frase es?: ");
				input = Console.ReadLine();

				if (input.Length <= 50)
				{
					Console.WriteLine("\nLa frase ingresada contiene: " + input.Length + " caracteres.");
				}
				else
				{
					Console.WriteLine("\nLa frase ingresada contiene muchos caracteres.");
				}
			}
			else if (opcion == "B")
			{
				Console.Write("\n\nLa palabra es?: ");
				input = Console.ReadLine();

				if (input.Length <= 10)
				{
					Console.WriteLine("\nLa palabra ingresada contiene: " + input.Length + " caracteres.");
				}
				else
				{
					Console.WriteLine("\nLa palabra ingresada contiene muchos caracteres.");
				}
			}
			else
			{
				Console.WriteLine("\nLa opción ingresada no existe.");
			}

			Thread.Sleep(10000);
		}
	}
}
