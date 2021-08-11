using System;

namespace ChallengeDirmod
{
	public class Program
	{
		static void Main(string[] args)
		{
			string descifrado = "";
			string cadena;

			do
			{
				Console.WriteLine("Para salir presione 'Enter' sin ingresar nada");
				Console.WriteLine("Solo se permiten letras (Excepto las acentuaciones)");
				Console.WriteLine("Ingrese la palabra o frase a descifrar: ");
				cadena = Console.ReadLine();
				char caracterAnterior = ' ';

				bool cadenaCorrecta = SoloLetrasYEspacios(cadena);

				if(cadenaCorrecta)
				{
					foreach(char caracter in cadena)
					{
						char caracterMinuscula = char.ToLower(caracter);
						descifrado = DescifrarCaracter(descifrado, caracterAnterior, caracterMinuscula);
						caracterAnterior = char.ToLower(caracter);
					}
					Console.WriteLine(descifrado);
				}
				descifrado = "";
			} while(cadena != "");
		}

		public static bool SoloLetrasYEspacios(string cadena)
		{
			bool control = true;
			foreach(char caracter in cadena)
			{
				if(!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
				{
					control = false;
				}
			}
			return control;
		}

		public static string DescifrarCaracter(string descifrado, char caracterAnterior, char caracterMinuscula)
		{
			if(caracterMinuscula == 'a')
			{
				if(caracterAnterior == 'a' || caracterAnterior == 'b' || caracterAnterior == 'c')
				{
					descifrado += " 2";
				}
				else
				{
					descifrado += "2";
				}
			}
			else if(caracterMinuscula == 'b')
			{
				if(caracterAnterior == 'a' || caracterAnterior == 'b' || caracterAnterior == 'c')
				{
					descifrado += " 22";
				}
				else
				{
					descifrado += "22";
				}
			}
			else if(caracterMinuscula == 'c')
			{
				if(caracterAnterior == 'a' || caracterAnterior == 'b' || caracterAnterior == 'c')
				{
					descifrado += " 222";
				}
				else
				{
					descifrado += "222";
				}
			}
			else if(caracterMinuscula == 'd')
			{
				if(caracterAnterior == 'd' || caracterAnterior == 'e' || caracterAnterior == 'f')
				{
					descifrado += " 3";
				}
				else
				{
					descifrado += "3";
				}
			}
			else if(caracterMinuscula == 'e')
			{
				if(caracterAnterior == 'd' || caracterAnterior == 'e' || caracterAnterior == 'f')
				{
					descifrado += " 33";
				}
				else
				{
					descifrado += "33";
				}
			}
			else if(caracterMinuscula == 'f')
			{
				if(caracterAnterior == 'd' || caracterAnterior == 'e' || caracterAnterior == 'f')
				{
					descifrado += " 333";
				}
				else
				{
					descifrado += "333";
				}
			}
			else if(caracterMinuscula == 'g')
			{
				if(caracterAnterior == 'g' || caracterAnterior == 'h' || caracterAnterior == 'i')
				{
					descifrado += " 4";
				}
				else
				{
					descifrado += "4";
				}
			}
			else if(caracterMinuscula == 'h')
			{
				if(caracterAnterior == 'g' || caracterAnterior == 'h' || caracterAnterior == 'i')
				{
					descifrado += " 44";
				}
				else
				{
					descifrado += "44";
				}
			}
			else if(caracterMinuscula == 'i')
			{
				if(caracterAnterior == 'g' || caracterAnterior == 'h' || caracterAnterior == 'i')
				{
					descifrado += " 444";
				}
				else
				{
					descifrado += "444";
				}
			}
			else if(caracterMinuscula == 'j')
			{
				if(caracterAnterior == 'j' || caracterAnterior == 'k' || caracterAnterior == 'l')
				{
					descifrado += " 5";
				}
				else
				{
					descifrado += "5";
				}
			}
			else if(caracterMinuscula == 'k')
			{
				if(caracterAnterior == 'j' || caracterAnterior == 'k' || caracterAnterior == 'l')
				{
					descifrado += " 55";
				}
				else
				{
					descifrado += "55";
				}
			}
			else if(caracterMinuscula == 'l')
			{
				if(caracterAnterior == 'j' || caracterAnterior == 'k' || caracterAnterior == 'l')
				{
					descifrado += " 555";
				}
				else
				{
					descifrado += "555";
				}
			}
			else if(caracterMinuscula == 'm')
			{
				if(caracterAnterior == 'm' || caracterAnterior == 'n' || caracterAnterior == 'o')
				{
					descifrado += " 6";
				}
				else
				{
					descifrado += "6";
				}
			}
			else if(caracterMinuscula == 'n')
			{
				if(caracterAnterior == 'm' || caracterAnterior == 'n' || caracterAnterior == 'o')
				{
					descifrado += " 66";
				}
				else
				{
					descifrado += "66";
				}
			}
			else if(caracterMinuscula == 'o')
			{
				if(caracterAnterior == 'm' || caracterAnterior == 'n' || caracterAnterior == 'o')
				{
					descifrado += " 666";
				}
				else
				{
					descifrado += "666";
				}
			}
			else if(caracterMinuscula == 'p')
			{
				if(caracterAnterior == 'p' || caracterAnterior == 'q' || caracterAnterior == 'r' || caracterAnterior == 's')
				{
					descifrado += " 7";
				}
				else
				{
					descifrado += "7";
				}
			}
			else if(caracterMinuscula == 'q')
			{
				if(caracterAnterior == 'p' || caracterAnterior == 'q' || caracterAnterior == 'r' || caracterAnterior == 's')
				{
					descifrado += " 77";
				}
				else
				{
					descifrado += "77";
				}
			}
			else if(caracterMinuscula == 'r')
			{
				if(caracterAnterior == 'p' || caracterAnterior == 'q' || caracterAnterior == 'r' || caracterAnterior == 's')
				{
					descifrado += " 777";
				}
				else
				{
					descifrado += "777";
				}
			}
			else if(caracterMinuscula == 's')
			{
				if(caracterAnterior == 'p' || caracterAnterior == 'q' || caracterAnterior == 'r' || caracterAnterior == 's')
				{
					descifrado += " 7777";
				}
				else
				{
					descifrado += "7777";
				}
			}
			else if(caracterMinuscula == 't')
			{
				if(caracterAnterior == 't' || caracterAnterior == 'u' || caracterAnterior == 'v')
				{
					descifrado += " 8";
				}
				else
				{
					descifrado += "8";
				}
			}
			else if(caracterMinuscula == 'u')
			{
				if(caracterAnterior == 't' || caracterAnterior == 'u' || caracterAnterior == 'v')
				{
					descifrado += " 88";
				}
				else
				{
					descifrado += "88";
				}
			}
			else if(caracterMinuscula == 'v')
			{
				if(caracterAnterior == 't' || caracterAnterior == 'u' || caracterAnterior == 'v')
				{
					descifrado += " 888";
				}
				else
				{
					descifrado += "888";
				}
			}
			else if(caracterMinuscula == 'w')
			{
				if(caracterAnterior == 'w' || caracterAnterior == 'x' || caracterAnterior == 'y' || caracterAnterior == 'z')
				{
					descifrado += " 9";
				}
				else
				{
					descifrado += "9";
				}
			}
			else if(caracterMinuscula == 'x')
			{
				if(caracterAnterior == 'w' || caracterAnterior == 'x' || caracterAnterior == 'y' || caracterAnterior == 'z')
				{
					descifrado += " 99";
				}
				else
				{
					descifrado += "99";
				}
			}
			else if(caracterMinuscula == 'y')
			{
				if(caracterAnterior == 'w' || caracterAnterior == 'x' || caracterAnterior == 'y' || caracterAnterior == 'z')
				{
					descifrado += " 999";
				}
				else
				{
					descifrado += "999";
				}
			}
			else if(caracterMinuscula == 'z')
			{
				if(caracterAnterior == 'w' || caracterAnterior == 'x' || caracterAnterior == 'y' || caracterAnterior == 'z')
				{
					descifrado += " 9999";
				}
				else
				{
					descifrado += "9999";
				}
			}
			else if(caracterMinuscula == ' ')
			{
				descifrado += "0";
			}

			return descifrado;
		}
	}
}