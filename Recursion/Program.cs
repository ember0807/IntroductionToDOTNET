using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Введите номер этажа : ");
			//int floor = Convert.ToInt32(Console.ReadLine());
			//Elevator(floor);

			Console.Write("Введдите число : ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"{n} ! = {Factorial(n)}");


		}
		static void Elevator(int floor)
		{
			if (floor == 0)
			{
				Console.WriteLine("Вы в подвале");
				return; 
			}
			Console.WriteLine($"Вы на {floor} этаже");
			Elevator(floor-1);
			Console.WriteLine($"Вы на {floor} этаже");
		}
		static int Factorial(int n)
		{
			//n! = (n-1)!*n;
			if (n == 0) { return 1; }
			else return n * Factorial(n-1);
		
		
		}
	}
}
