using System;

namespace SimulacionPrimerParcial2022
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool Validacion(int x, int y, int numero)
            {
                if ((numero>=x) && (numero<=y))
                {
                    var validacion = true;
                    return validacion;
                }
                else
                {
                    var validacion = false;
                    return validacion;
                }
            }
            Console.Write("Ingrese la HORA: ");
            var hora = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los MINUTOS: ");
            var minutos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los SEGUNDOS: ");
            var segundos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese AM o PM: ");
            var ampm = Console.ReadLine();



            if ((Validacion(0,12,hora) == true) && (Validacion(0,60,minutos) == true) && (Validacion(0,60,segundos) == true))
            {
                if (ampm.ToUpper() == "AM")
                {
                    Console.Write("La hora ingresada es {0}:{1}:{2} {3}", hora, minutos, segundos, ampm.ToUpper());
                }
                else
                {
                    if (ampm.ToUpper() == "PM")
                    {
                        hora = hora + 12;
                        Console.Write("La hora ingresada es {0}:{1}:{2} {3}", hora, minutos, segundos, ampm.ToUpper());
                    }
                    else
                    {
                        Console.Write("Error al ingresar los datos...");
                    }
                }
            }
            else
            {
                Console.Write("La hora que se ha ingresado es incorrecta, por favor verifique...");
            }
            

        }
    }
}
