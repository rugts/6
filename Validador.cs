using System;

using System.Collections.Generic;

using System.Linq;

using System.Net;

using System.Text;

using System.Threading.Tasks;



namespace Caso_semana11

{

	internal class Validador

	{

		public static int LeerEntero(string mensaje)

		{

			int valor;

			while (true)
			{

				Console.Write(mensaje);

				if (int.TryParse(Console.ReadLine(), out valor))

				{

					if (valor < 1 || valor > 5)

					{

						Console.WriteLine("Error: El valor es entre [1,5]");

						continue;

					}

					return valor;

				}

				Console.WriteLine("Error: EL VALOR DEBE SER NÚMERICO ENTERO");

			}

		}



		public static double LeerDecimales(string mensaje)

		{



			double valor;

			while (true)

			{

				Console.Write(mensaje);

				if (double.TryParse(Console.ReadLine(), out valor))

				{

					if (valor < 0 || valor > 20)

					{

						Console.WriteLine("La nota es entre [0,20]");

						continue;

					}

					return valor;

				}

				Console.WriteLine("Error: El valor debe ser númerico decimal");

			}

		}

		public static string LeerTexto(string mensaje)

		{

			while (true)

			{

				Console.Write(mensaje);

				string texto = Console.ReadLine()?.Trim();

				if (!String.IsNullOrEmpty(texto))

					return texto;

				Console.WriteLine("Error: Este campo no puede ser vacio...!!");



			}

		}

	}

}