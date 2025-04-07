using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculadora_20250407
{
	class Program
	{
		static void Main(string[] args)
		{
			String title = "La mejor calculadora del mundo (v2.0)";
			
			Console.Write("\n" + title + "\n\nCopyright (c) 2025 Bruno Suarez\n");
			Console.Title = title;

			int operacion;
			double numero_1, numero_2, resultado;

			Console.Write("\nSeleccione una de las operaciones a realizar escribiendo el numero relacionado, al finalziar presione enter:\n\n1) Suma\n2) Resta\n3) Division\n4) Multiplicacion\n\nOperacion: ");
			operacion = Convert.ToInt32(Console.ReadLine());

			Console.Write("Escriba un valor numerico y luego precione enter: ");
			numero_1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Escriba un segundo valor numerico y luego precione enter: ");
			numero_2 = Convert.ToDouble(Console.ReadLine());

			// verificar que el valor introducido en division no sea 0
			while ((operacion == 3) && (numero_2 == 0))
			{
				Console.Write("El numero de una division no debe ser 0.\nEscriba un segundo valor numerico y luego precione enter: ");
				numero_2 = Convert.ToInt64(Console.ReadLine());
			}

			switch (operacion)
				{
					// sumar
					case 1:
						resultado = numero_1 + numero_2;
						Console.WriteLine($"El resultado de suma es: {resultado}");
					break;

					// restar
					case 2:
						resultado = numero_1 - numero_2;
						Console.WriteLine($"El resultado de resta es: {resultado}");
					break;

					// dividir
					case 3:
						resultado = numero_1 / numero_2;
						Console.WriteLine($"El resultado de division es: {resultado}");
					break;

					// multiplciar
					case 4:
						resultado = numero_1 * numero_2;
						Console.WriteLine($"El resultado de multiplcacion es: {resultado}");
					break;

					default:
						Console.WriteLine($"El numero {operacion} no pertenece a una operacion matematica.");
					break;
				}

			Console.WriteLine($"\n\nCerrando {title}...");
			Thread.Sleep(5000);
		}
	}
}