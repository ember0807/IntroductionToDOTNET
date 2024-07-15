
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	class Program
	{
		static void Main(string[] args)
		{
			//Point A = new Point();
			//A.ToString();
			////A.SetX(2);
			////A.SetY(3);
			////Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");

			//A.X = 22;
			//A.Y = 133;
			//Console.WriteLine($"X = {A.X}\tY = {A.Y}");



			// Создание объектов класса Fraction
			Fraction fraction1 = new Fraction(10, 25);
			Fraction fraction2 = new Fraction(30, 400);

			// Вызов операций над дробями
			Fraction sum = fraction1.Add(fraction2);
			Fraction difference = fraction1.Subtract(fraction2);
			Fraction product = fraction1.Multiply(fraction2);
			Fraction quotient = fraction1.Divide(fraction2);

			// Вывод результатов операций
			Console.WriteLine($"Сумма: {sum}");
			Console.WriteLine($"Разность: {difference}");
			Console.WriteLine($"Произведение: {product}");
			Console.WriteLine($"Частное: {quotient}");

		}
	}
	struct Point
	{
		//double x;
		//double y;
		//public double X
		//{
		//	get { return x; }
		//	set { this.x = value; }
		//}
		//public double Y
		//{
		//	get => y;
		//	set
		//	{
		//		value = value < 0 ? 0 : value;
		//		value = value > 100 ? 100 : value;
		//		this.y = value;
		//	}
		//}
		//public double GetX()
		//{
		//	return x;
		//}
		//public double GetY()
		//{
		//	return y;
		//}
		//public void SetX(double x)
		//{
		//	this.x = x;
		//}
		//public void SetY(double y)
		//{
		//	this.y = y;
		//}
		public double X { get; set; }
		public double Y { get; set; }
		//Garbage collector
		//CLR
	}
}
/*
-----------------------------------
private:			закрытые поля, доступны только внутри класса;
public:				открытые поля, доступны в любом месте как в пределах данной сборки, так и за ее пределами; 
protected:			защищенные поля, достудны внутри класса, и его дочерних классов;
internal:			эти поля доступны где угодно в пределах данной сборки;
protected internal: защищенный внутренние поля, доступны как в классе, так и в его дочерних классах в пределах данной сборки;
-----------------------------------
Get/Set-methods
-----------------------------------
Properties
-----------------------------------
 */
