﻿//#define TALK1
#define TALK2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if TALK1
			Console.WriteLine("Введите просто арифметическое выражение : ");
			string expression = Console.ReadLine();
			expression = expression.Replace('.', ','); // изменяет одно значение на другое при вводе нужно сохранять в переменную
			Console.WriteLine(expression);
			String[] numbers = expression.Split('+', '-', '*', '/');
			//for (int i = 0; i < numbers.Length; i++) Console.WriteLine(numbers[i]+"\t");			
			double a = Convert.ToDouble(numbers[0]);
			double b = Convert.ToDouble(numbers[1]);
			char s = expression[expression.IndexOfAny(new char[] { '+', '-', '*', '/' })];
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(s);
			switch (s)
			{ 
				case '+': Console.WriteLine($"{a} + {b} = {a + b}");break;
				case '-': Console.WriteLine($"{a} - {b} = {a - b}");break;
				case '*': Console.WriteLine($"{a} * {b} = {a * b}");break;
				case '/': Console.WriteLine($"{a} / {b} = {a / b}");break;
			
			}
			Main(args);// рукурсивный вызов функции main(), при завершении программы она заново запускается
#endif
			//correct = true;
			//Console.WriteLine("Введите арифмитическое выражение");
			//string expression = Console.ReadLine();
			//string expression = "22 + 33 * 44 - 55 / 5";
			string expression = "(22 + 33 *( 44 + 55)) / 5";
			Console.WriteLine($"Result: {Browse(expression)}");
			//Console.WriteLine("Введите арифмитическое выражение");
			

            //Main(args);
        }
		static double Browse(string expression)
		{
			expression = expression.Replace(" ", "");
			for (int i = 0; i < expression.Length; i++)
			{
				if (expression[i] == '(')
				{
					for (int j = i + 1; j < expression.Length; j++)
					{ 
						if (expression[j] == ')')
						{
							//string subexpression = expression.Substring(i, j-i);
							//double result = Calculate(subexpression.Substring(1, subexpression.Length - 2));
							//expression = expression.Replace(subexpression, result.ToString());
							string subexpression = expression.Substring(i+1, j-i-1);
							double result = Calculate(subexpression);
							
							expression = expression.Replace($"({subexpression})",result.ToString());
							break;
						}
						else if (expression[j] == '(')
						{
							Browse(expression.Substring(j+1 , expression.Length - 1 - j));
						}
					}
				}
			}
			return Calculate(expression);
		}
		static double Calculate(string expression)
		{
			
			string s_operations = "+-*/";
			String[] s_numbers = expression.Split(s_operations.ToCharArray());
			s_numbers = s_numbers.Where(item => item != "").ToArray();
			double[] d_numbers = new double[s_numbers.Length];
			for (int i = 0; i < s_numbers.Length; i++)
			{
				d_numbers[i] = Convert.ToDouble(s_numbers[i]);
				Console.Write(d_numbers[i] + "\t ");

			}
			Console.WriteLine();
			char[] c_operations = expression.Where(item => s_operations.Contains(item)).ToArray();
			for (int i = 0; i < c_operations.Length; i++)
			{
				Console.WriteLine(c_operations[i] + "\t");
			}
			Console.WriteLine();

			if (d_numbers.Length != c_operations.Length + 1)
			{
				//Console.WriteLine("Выражение некорректно, повторите ввод...");
				//continue;
				throw new Exception("Expression is incorrect");
			}

			//while(c_operations.Contains('*')|| c_operations.Contains ('/'))
			{
				for (int i = 0; i < c_operations.Length; i++)
				{

					while (c_operations[i] == '*' || c_operations[i] == '/')
					{
						if (c_operations[i] == '*') d_numbers[i] *= d_numbers[i + 1];
						if (c_operations[i] == '/') d_numbers[i] /= d_numbers[i + 1];

						for (int j = i + 1; j < d_numbers.Length - 1; j++) d_numbers[j] = d_numbers[j + 1];
						for (int j = i; j < c_operations.Length - 1; j++) c_operations[j] = c_operations[j + 1];
						d_numbers[d_numbers.Length - 1] = 0;
						c_operations[c_operations.Length - 1] = '\0';
					}
				}
			}
			for (int i = 0; i < c_operations.Length; i++)
			{

				while (c_operations[i] == '+' || c_operations[i] == '-')
				{
					if (c_operations[i] == '+') d_numbers[i] += d_numbers[i + 1];
					if (c_operations[i] == '-') d_numbers[i] -= d_numbers[i + 1];

					for (int j = i + 1; j < d_numbers.Length - 1; j++) d_numbers[j] = d_numbers[j + 1];
					for (int j = i; j < c_operations.Length - 1; j++) c_operations[j] = c_operations[j + 1];
					d_numbers[d_numbers.Length - 1] = 0;
					c_operations[c_operations.Length - 1] = '\0';
				}

			}
			for (int i = 0; i < d_numbers.Length; i++)
			{
				Console.Write(d_numbers[i] + "\t");
			}
			Console.WriteLine();
			for (int i = 0; i < c_operations.Length; i++)
			{
				Console.Write(c_operations[i] + "\t");
			}
			Console.WriteLine();
			return d_numbers[0];
		}
	}
}
