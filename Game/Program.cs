using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		static int x = 50;
		static int y = 20;

		static void Main()
		{
			while (true)
			{
				Console.Clear();
				DrawSquare();

				ConsoleKey key = Console.ReadKey().Key;

				if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
				{
					y--;
				}
				else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
				{
					y++;
				}
				else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
				{
					x--;
				}
				else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
				{
					x++;
				}
				else if (key == ConsoleKey.Escape)
				{
					return;
				}	
			}
		}

		static void DrawSquare()
		{
			for (int i = 0; i < y; i++)
			{
				Console.WriteLine();
			}

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < x; j++)
				{
					Console.Write(" ");
				}

				Console.WriteLine("***");
			}
		}

	}
}
