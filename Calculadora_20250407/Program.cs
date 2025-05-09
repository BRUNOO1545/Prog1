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
			Console.Title = title;

			int operacion;
			double numero_1 = 0, numero_2 = 0, resultado;

			string opcion;
			bool continuar = true;

			do
			{
				Console.Clear();
				Console.Write($"\nSeleccione una de las operaciones a realizar escribiendo el numero relacionado, al finalziar presione enter:\n\n1) Suma\n2) Resta\n3) Division\n4) Multiplicacion\n5) Cerrar {title}\n\nOperacion: ");
				operacion = Convert.ToInt32(Console.ReadLine());

				if (operacion != 5)
				{
					Console.Write("Escriba un valor numerico y luego precione enter: ");
					numero_1 = Convert.ToDouble(Console.ReadLine());

					Console.Write("Escriba un segundo valor numerico y luego precione enter: ");
					numero_2 = Convert.ToDouble(Console.ReadLine());
				}

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

					// cerrar
					case 5:
						continuar = false;
					break;

					default:
						Console.WriteLine($"El numero {operacion} no pertenece a una operacion matematica.");
					break;
				}

				// continuar
				if (continuar)
				{
					opcion = "";
					Console.Write("\n\nDesea hacer una nueva operacion (S / N): ");
					opcion = Console.ReadLine();

					if (opcion == "n")
					{
						continuar = false;
					}
					else if (opcion == "s")
					{
						continuar = true;
					}
				}

			} while (continuar);

			Console.Clear();
			Console.WriteLine($"\n\nCerrando {title}...");
			Thread.Sleep(5000);
		}
	}
}