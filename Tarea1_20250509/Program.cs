using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250509
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea 1: Imprimir solo los numeros pares impares entre 1 y 20
			for (int i = 1; i <= 20; i++)
			{
				if (i % 2 == 0) continue;

				Console.Write(i);
			}

			Thread.Sleep(5000);
		}
	}
}
