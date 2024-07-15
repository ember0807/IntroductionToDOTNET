using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
		public class Fraction
		{
			public int Numerator { get; private set; }
			public int Denominator { get; private set; }

			public Fraction(int numerator, int denominator)
			{
				if (denominator == 0)
				{
					throw new ArgumentException("Знаменатель не может быть равен нулю");
				}

				int gcd = FindGCD(Math.Abs(numerator), Math.Abs(denominator));
				Numerator = numerator / gcd;
				Denominator = denominator / gcd;

				if (Denominator < 0)
				{
					Numerator = -Numerator;
					Denominator = -Denominator;
				}
			}

			public Fraction Add(Fraction other)
			{
				int newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
				int newDenominator = Denominator * other.Denominator;
				return new Fraction(newNumerator, newDenominator);
			}

			public Fraction Subtract(Fraction other)
			{
				int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
				int newDenominator = Denominator * other.Denominator;
				return new Fraction(newNumerator, newDenominator);
			}

			public Fraction Multiply(Fraction other)
			{
				int newNumerator = Numerator * other.Numerator;
				int newDenominator = Denominator * other.Denominator;
				return new Fraction(newNumerator, newDenominator);
			}

			public Fraction Divide(Fraction other)
			{
				if (other.Numerator == 0)
				{
					throw new ArgumentException("Деление на ноль не допускается");
				}

				int newNumerator = Numerator * other.Denominator;
				int newDenominator = Denominator * other.Numerator;
				return new Fraction(newNumerator, newDenominator);
			}

			public override string ToString()
			{
				if (Denominator == 1)
				{
					return $"{Numerator}";
				}
				else
				{
					return $"{Numerator}/{Denominator}";
				}
			}

			private int FindGCD(int a, int b)
			{
				while (b != 0)
				{
					int temp = b;
					b = a % b;
					a = temp;
				}
				return a;
			}
		}
	}

