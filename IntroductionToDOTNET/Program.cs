//#define CLASS_CONSOLE
#define STRINGS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CLASS_CONSOLE
            Console.Title = "Введение в .NET";
            Console.Write("\t\t\tHelo.NET");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.SetCursorPosition(22, 11);
            //Console.CursorLeft = 32;
            //Console.CursorTop = 11;
            Console.Beep(316, 1000);
            Console.Clear();
            Console.WriteLine("\nПривет .NET");
            Console.ResetColor();
#endif
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("введите вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			/* Console.Write(first_name+" ");
             Console.Write(last_name+" ");
             Console.Write(age + " ");
             Console.WriteLine(); //cout << endl;*/

			//Console.WriteLine(last_name + " " + first_name + " " + age); // конкатинация строк

			//Console.WriteLine(string.Format("{0} {1} {2}", last_name,first_name,age)); //форматирование строк

			Console.WriteLine($"{last_name} {first_name} {age}"); //интерполяция строк

		}
	}
}
