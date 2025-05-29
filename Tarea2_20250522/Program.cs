using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_20250522
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea: Pedir al usuario dos numeros enteros y que el programa valide que lo sean.

			int numero_1, numero_2;
			bool error = true;

			do
			{
				try
				{
					Console.Write("Ingrese un numero: ");
					numero_1 = Convert.ToInt32(Console.ReadLine());
					error = false;
				}
				catch
				{
					Console.WriteLine("Error...");
				}
			} while (error);

			error = true;

			do
			{
				try
				{
					Console.Write("\nIngrese un segundo numero: ");
					numero_2 = Convert.ToInt32(Console.ReadLine());
					error = false;
				}
				catch
				{
					Console.WriteLine("Error...");
				}
			} while (error);
		}
	}
}
