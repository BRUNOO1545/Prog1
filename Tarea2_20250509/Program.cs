using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea2_20250509
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea 2: Imprimir solo los numeros que son divisibles por 3 entre 0 y 50
			for (int i = 0; i < 50; i++)
			{
				if (i % 3 == 0) continue;
				
				Console.Write(i + ", ");
			}

			Thread.Sleep(50000);
		}
	}
}
