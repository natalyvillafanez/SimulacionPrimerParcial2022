using System;

namespace CopiaPseint
{
	class Program
	{

		static bool Verificacion(int inicio, int stop, int num)
		{
			if ((num >= inicio) && (num <= stop))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static void Main(string[] args)
		{
			int hora, minutos, segundos;
			string pmam, siNo;

			Console.Write(("Ingrese la HORA: "));
			hora = int.Parse(Console.ReadLine());
			Console.Write(("Ingrese los MINUTOS: "));
			minutos = int.Parse(Console.ReadLine());
			Console.Write(("Ingrese los SEGUNDOS: "));
			segundos = int.Parse(Console.ReadLine());

			if ((Verificacion(0, 12, hora) == true) && (Verificacion(0, 59, minutos) == true) && (Verificacion(0, 59, segundos) == true))
			{
				Console.Write(("¿PM o AM?"));
				pmam = Console.ReadLine();

				if ((pmam.ToUpper()=="AM") || (pmam.ToUpper() == "PM"))
				{
					Console.WriteLine("La hora es {0}:{1}:{2} {3}", hora, minutos, segundos, pmam.ToUpper());
					Console.WriteLine("¿Desea ver la hora ingresada en formato de 24 hs? SI/NO");
					siNo = Console.ReadLine();

					if ((siNo.ToUpper() == "SI"))
					{
						if ((pmam.ToUpper() == "PM"))
						{
							Console.WriteLine("La hora en formato 24 hs es {0}:{1}:{2}",(hora + 12), minutos, segundos);
						}
						else
						{
							Console.WriteLine("La hora en formato 24 hs es {0}:{1}:{2}", hora, minutos, segundos);
						}
					}
					else

					{
						if ((siNo.ToUpper() == "NO"))
						{
							Console.WriteLine("Fin del programa...");
						}
						else
						{
							Console.WriteLine("Ingreso incorrecto, por favor verifique...");
						}
					}
				}
				else
				{
					Console.WriteLine("Ingreso incorrecto, por favor verifique...");
				}
			}
			else
			{
				Console.WriteLine("Hora ingresada fuera de rango, por favor verifique...");
			}
		}

	}

}

