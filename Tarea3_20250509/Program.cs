using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea3_20250509
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea 3: Imprimir la sumatoria de todos los numeros que hay entre 1 y 100
			int total = 0;

			for (int i = 1; i <= 100; i++)
			{
				total += i;
			}

			Console.Write(total);

			Thread.Sleep(5000);
		}
	}
}
