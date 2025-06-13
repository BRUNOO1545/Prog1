using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tarea1_20250515
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
				Tarea 1: Hacer un programa que simule un juego con dados, con 3 dados, el usuario arroja los dados, y se obtienen 3 valores aleatorios entre 1 y 6.
				La idea es que si el usuario obtiene una suma total mayor a 12 entonces dee recibir un mensaje de que GANÓ!! caso contrario será "PERDIÓ".

				Requerimientos:
					- Menu de recursos (reintentos a gusto del ususario).
					- Uso de Random.
					- Mensajes claros para el usuario.

				Desafio: haccer que sea para dos jugadores y que se intercale el turno entre ellos.
				Juegan los dos, y al final muestra los resultados indicando quien ganó y si fué un empate.
			*/

			string optionMenu;
			bool continuePlaying;

			do
			{
				continuePlaying = true;

				// menu principal
				Console.Clear();
				Console.Write("Bienvenido al juego de dados\n\nSeleccione una opcion para continuar:\n\n\t1) Modo un jugador.\n\t2) Modo dos jugadores.\n\t3) En que consiste el juego.\n\t4) Cerrar juego.\n\nEscriba el numero y juego presione enter.\nOpcion: ");
				optionMenu = Console.ReadLine();

				switch (optionMenu)
				{
					#region Modo 1 jugador
					case "1":
						Console.Clear();

						Random rndVal = new Random();
						int dado_1, dado_2, dado_3, total_dados;

						dado_1 = rndVal.Next(1, 7);
						Thread.Sleep(500);
						dado_2 = rndVal.Next(1, 7);
						Thread.Sleep(500);
						dado_3 = rndVal.Next(1, 7);

						total_dados = dado_1 + dado_2 + dado_3;

						Console.WriteLine($"Resultado: {total_dados} ({dado_1}, {dado_2}, {dado_3})");

						if (total_dados > 12)
						{
							Console.WriteLine("USTED GANO!!!");
						}
						else
						{
							Console.WriteLine("USTED PERDIO...");
						}


						Console.WriteLine("\n\n\nPresione una tecla para volver al menu principal.");
						Console.ReadKey();
						break;
					#endregion

					#region Modo 2 jugadores
					case "2":
						Console.Clear();

						Random rndValP1 = new Random();
						Random rndValP2 = new Random();
						int dado_1_p1, dado_2_p1, dado_3_p1, total_dados_p1;
						int dado_1_p2, dado_2_p2, dado_3_p2, total_dados_p2;

						// jugador 1
						Console.Clear();
						Console.WriteLine("Le toca al jugador 1:\n\nPresione Enter para continuar...");
						Console.ReadKey();

						dado_1_p1 = rndValP1.Next(1, 7);
						Thread.Sleep(500);
						dado_2_p1 = rndValP1.Next(1, 7);
						Thread.Sleep(500);
						dado_3_p1 = rndValP1.Next(1, 7);

						total_dados_p1 = dado_1_p1 + dado_2_p1 + dado_3_p1;

						// jugador 2
						Console.Clear();
						Console.WriteLine("Le toca al jugador 2:\n\nPresione Enter para continuar...");
						Console.ReadKey();

						dado_1_p2 = rndValP1.Next(1, 7);
						Thread.Sleep(500);
						dado_2_p2 = rndValP1.Next(1, 7);
						Thread.Sleep(500);
						dado_3_p2 = rndValP1.Next(1, 7);

						total_dados_p2 = dado_1_p2 + dado_2_p2 + dado_3_p2;

						Console.Clear();
						Console.WriteLine($"Resultados:\n\tJugador 1: {total_dados_p1} ({dado_1_p1}, {dado_2_p1}, {dado_3_p1})\n\tJugador 2: {total_dados_p2} ({dado_1_p2}, {dado_2_p2}, {dado_3_p2})\n\n");

						if (total_dados_p1 > total_dados_p2)
						{
							Console.WriteLine("JUGADOR 1 GANO!!!");
						}
						else if (total_dados_p1 == total_dados_p2)
						{
							Console.WriteLine("EMPATARON!!!");
						}
						else
						{
							Console.WriteLine("JUGADOR 2 GANO!!!");
						}


						Console.WriteLine("\n\n\nPresione una tecla para volver al menu principal.");
						Console.ReadKey();
						break;
					#endregion

					#region En que consiste
					case "3":
						Console.Clear();
						Console.WriteLine("En que consiste el juego:\n\nMODO UN JUGADOR:\n\tEl jugador al tirar los dados debe superar una puntuacion mayor a 12.\n\nMODO DOS JUGADORES:\n\tEl jugador que obtenga la mayor puntuacion entre los 2 gana.");	

						Console.ReadKey();
						break;
					#endregion

					#region Salir
					case "4":
						continuePlaying = false;
						break;
					#endregion

					#region Error
					default:
						Console.Clear();
						Console.WriteLine("ERROR: El numero ingresado no corresponde a una opcion.\n\nPresione una tecla para mostrar el menu nuevamente...");
						Console.ReadKey();
						break;
					#endregion
				}
			} while (continuePlaying);
		}
	}
}
