using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250522
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea: Usando Try catch, pedir al usuario que ingrese una letra/caracter y que indique un error si es mas de una.

			Console.Write("Ingrese una letra: ");

			char letra;

			try
			{
				letra = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Gracias...");
			}
			catch
			{
				Console.WriteLine("Error...");
			}

			Thread.Sleep(5000);
		}
	}
}
