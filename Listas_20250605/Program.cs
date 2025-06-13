using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_20250605
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> nombres = new List<string>();
			List<int> numeros = new List<int>();

			nombres.Add("ana");
			nombres.Add("pedro");
			numeros.Add(2);

			foreach (string nombre in nombres)
			{
				Console.WriteLine(nombre);
			}

			foreach (int num in numeros)
			{
				Console.WriteLine(num);
			}

			Console.ReadKey();
		}
	}
}
