using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificacion_Jose_Antonio_FPC
{
    class Program
    {
		static void Main(string[] args)
		{
			//declarar variables
			string nombre;
			double calificacion1;
			double calificacion2;
			double calificacion3;
			double promedio;
			string matricula;
			string materia;
			//asignar variables
			Console.WriteLine("Escribe tu nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("escribe tu maticula");
			matricula = Console.ReadLine();
			Console.WriteLine("escribe el nombre de la materia");
			materia = Console.ReadLine();
			Console.WriteLine("Escribe la calificaciones: ");
			calificacion1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("segunda cali");
			calificacion2 = Double.Parse(Console.ReadLine());
			Console.WriteLine("tercera cali");
			calificacion3 = Double.Parse(Console.ReadLine());
			//usar operadores para sacar el porcentaje
			promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
			//utilizar if
			if (promedio >= 70)
			{
				//cambiar colr
				Console.BackgroundColor = ConsoleColor.Green;
				Console.WriteLine("Nombre: " + nombre);
				Console.WriteLine("matricula: " + matricula);
				Console.WriteLine("matricula " + materia);
				Console.WriteLine("Tu promedio es: " + promedio + " aprobaste ");
			}
			else
			{
				//cambiar color
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine("Nombre: " + nombre);
				Console.WriteLine("matricula: " + matricula);
				Console.WriteLine("matricula " + materia);
				Console.WriteLine("Tu promedio es: " + promedio + " no aprobaste");
			}
			Console.ReadKey();
		}

	}

}