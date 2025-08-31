using System;
using System.Threading;

namespace TP1_Ejericio_1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			
			 Enunciado: Crear un programa en consola que lea un numero entero ingresado por el usuario y 
			 realice las siguientes verificaciones:
				- Informar si el numero es positivo, negativo o cero.
				- Informar si el numero es par o impar.
				- Si el numero esta entre 1 y 100 (inclusive), mostrar "Número dentro del rango permitido".
				- Si el numero no esta dentro del rango mostrar "Número fura del rango permitido".
			 
			 Objetivo: Aplicar expresiones, operadores logicos y estructura if.

			 Requisitos técnicos:
				- Declaración de variables y expresiones lógicas
				- Uso de if, operadores relacionales y lógicos
				- Operadores condicionales
				- Mostrar resultado en consola

			*/

			int valor = 0;

			Console.Write("Ingrese un número: ");

			Console.ForegroundColor = ConsoleColor.Red;
			valor = Convert.ToInt32(Console.ReadLine());
			Console.ResetColor();
			Console.WriteLine();

			if (valor == 0)
			{
				Console.WriteLine("El número es Cero.");
			}
			else if (valor > 0)
			{
				Console.WriteLine("El número es positivo.");
			}
			else
			{
				Console.WriteLine("El número es negativo.");
			}

			if (valor % 2 == 0)
			{
				Console.WriteLine("El número es par.");
			}
			else
			{
				Console.WriteLine("El número es impar.");
			}

			if ((valor >= 1) && (valor <= 100))
			{
				Console.WriteLine("Número dentro del rango permitido.");
			}
			else
			{
				Console.WriteLine("Número fura del rango permitido.");
			}

			Thread.Sleep(5000);
		}
	}
}