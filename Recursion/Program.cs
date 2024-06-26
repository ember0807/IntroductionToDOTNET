using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
			try
			{
				DateTime start = DateTime.Now;
				Console.WriteLine($"\n-----------------\n {n}! = {Factorial(n)}");
				DateTime end = DateTime.Now;
				TimeSpan duration = end - start;
				Console.WriteLine($"Duration : {duration.ToString("g")}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{ex.ToString()} : {ex.Message}");
			}
			//Console.WriteLine($"{n} ! = {Factorial(n)}");
			Console.WriteLine("Buy");

		}
		static void Elevator(int floor)
		{
			if (floor == 0)
			{
				Console.WriteLine("Вы в подвале");
				return;
			}
			Console.WriteLine($"Вы на {floor} этаже");
			Elevator(floor - 1);
			Console.WriteLine($"Вы на {floor} этаже");
		}
		static BigInteger Factorial(long n)
		{
			BigInteger f = 1;
			for (int i = 1; i < n; i++)
			{
				f *= i;
			}
			return f;
			////n! = (n-1)!*n;
			//if (n == 0) { return 1; }
			//BigInteger f = n * Factorial(n - 1);
			////else return n * Factorial(n-1);
			//Console.WriteLine($"{n}! = {f}");
			//return f;
		}
		static long Factorial1(long n)
		{
			if (n == 0) return 1;
			long f = n * Factorial1(n - 1);
			Console.WriteLine($"{n}! = {f}");
			return f;
		}
		static double Power(double a, int n)
		{
			if (n == 0) return 1;
			else if (n > 0) return a * Power(a, n - 1);
			else return 1 / Power(a, -n);

		}
		static double Power1(double a, int n)
		{
			return n == 0 ? 1 : n > 0 ? a * Power(a, n - 1) : 1 / Power(a, -n);
		}
	}
}
