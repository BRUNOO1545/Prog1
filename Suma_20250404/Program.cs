using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Suma_20250404
{
	class Program
	{
		static void Main(string[] args)
		{
			String titulo = "la mejor calculadora del mundo";
			Console.Title = titulo;
			Console.WriteLine("Bienvenido a " + titulo);

			Int64 numero_1, numero_2, resultado;

			Console.WriteLine("Introduzca un primer valor numerico: ");
			numero_1 = Convert.ToInt64(Console.ReadLine());

			Console.WriteLine("Ahora, introduzca un segundo valor numerico: ");
			numero_2 = Convert.ToInt64(Console.ReadLine());

			resultado = numero_1 + numero_2;

			Console.WriteLine("El resultado de la suma es: " + resultado);

			Thread.Sleep(5000);
		}
	}
}