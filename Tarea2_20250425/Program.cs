using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea2_20250425
{
	class Program
	{
		static void Main(string[] args)
		{
			// Tarea: desarollar un juego

			int opcion_usuario, opcion_ia;
			bool rejugar = true;
			Random random_val = new Random();

			Console.Title = "Piedra, papel o tijeras";

			while (rejugar)
			{
				Console.Write("Elije una opcion:\n\n\t1) Piedra\n\t2) Papel\n\t3) Tijeras\n\nOpcion a elejir (luego presiona enter): ");
				opcion_usuario = Convert.ToInt32(Console.ReadLine());
				opcion_ia = random_val.Next(1, 4);

				Console.WriteLine(opcion_ia);

				

				Console.Write("Quieres volver a jugar?:\n\n\t1) Si\n\t2) No\n\nOpcion a elejir (luego presiona enter): ");
				rejugar = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()) - 1);

				if (rejugar)
				{
					Console.Clear();
				}
			}

			Console.Clear();
			Console.WriteLine("Gracias por jugar.");

			Thread.Sleep(5000); 
		}
	}
}
