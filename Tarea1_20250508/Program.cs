using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250508
{
	class Program
	{
		static void Main(string[] args)
		{
			// Bucles For, imprimir una matriz de valores

			Console.WriteLine("\n1)");

			for (int f = 0; f <= 5; f++)
			{
				for (int c = 0; c < 8; c++)
				{
					if (f % 2 == 0)
					{
						Console.Write("0 ");
					}
					else
					{
						Console.Write("1 ");
					}
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n2)");

			for (int f = 0; f <= 4; f++)
			{
				for (int c = 0; c <= 4; c++)
				{
					if (f == c)
					{
						Console.Write("1 ");
					}
					else
					{
						Console.Write("0 ");
					}
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n3)");

			for (int f = 0; f <= 4; f++)
			{
				for (int c = 0; c <= 4; c++)
				{
					if (((f == 0) || (f == 4)) || ((c == 0) || (c == 4)))
					{
						Console.Write("1 ");
					}
					else
					{
						Console.Write("0 ");
					}
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n4)");

			for (int f = 0; f <= 4; f++)
			{
				for (int c = 0; c <= 4; c++)
				{
					if ((4 - f) == c)
					{
						Console.Write("1 ");
					}
					else
					{
						Console.Write("0 ");
					}
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n5)");

			for (int f = 0; f <= 4; f++)
			{
				for (int c = 0; c <= 4; c++)
				{
					if ((f == c) || ((4 - f) == c))
					{
						Console.Write("1 ");
					}
					else
					{
						Console.Write("0 ");
					}
				}

				Console.WriteLine();
			}

			Console.WriteLine("\n6)");

			for (int f = 0; f < 4; f++)
			{
				for (int c = 0; c <= 4; c++)
				{
					Console.Write((f * c) + " ");
				}

				Console.WriteLine();
			}


			Thread.Sleep(50000);
		}
	}
}
