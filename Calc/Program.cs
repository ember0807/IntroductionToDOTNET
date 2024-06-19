using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double num1, num2;
			char operation;

			Console.WriteLine("Введите первое число:");
			num1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите операцию (+, -, *, /):");
			operation = char.Parse(Console.ReadLine());

			Console.WriteLine("Введите второе число:");
			num2 = double.Parse(Console.ReadLine());

			if (operation == '+')
			{
				Console.WriteLine($"Результат: {num1} + {num2} = {num1 + num2}");
			}
			else if (operation == '-')
			{
				Console.WriteLine($"Результат: {num1} - {num2} = {num1 - num2}");
			}
			else if (operation == '*')
			{
				Console.WriteLine($"Результат: {num1} * {num2} = {num1 * num2}");
			}
			else if (operation == '/')
			{
				if ( num2 != 0)
				{
					Console.WriteLine($"Результат: {num1} / {num2} = {num1 / num2}");
				}
				else
				{
					Console.WriteLine("Ошибка: деление на ноль!");
				}
			}
			else
			{
				Console.WriteLine("Ошибка: неверная операция!");
			}
		}
	}
}
