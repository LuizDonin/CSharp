﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com seu nome completo:");
			string fullName = Console.ReadLine();
			Console.WriteLine("Quantos quartos tem na sua casa?");
			int bedrooms = int.Parse(Console.ReadLine());
			Console.WriteLine("Entre com o preço de um produto:");
			double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
			string[] vect = Console.ReadLine().Split(' ');
			string lastName = vect[0];
			int age = int.Parse(vect[1]);
			double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

			Console.WriteLine(fullName);
			Console.WriteLine(bedrooms);
			Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine(lastName);
			Console.WriteLine(age);
			Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

			Console.ReadLine();

		}
	}
}
