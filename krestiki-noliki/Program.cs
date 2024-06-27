//#define GAME_DONT_RECURSSION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestiki_noliki
{
	internal class Program
	{
		// Инициализация игрового поля
		static char[] board = { '1', '2', '3', '4', '5','6','7', '8', '9' };
		// Флаг для определения очередности игроков
		static bool player1Turn = true;
#if GAME_DONT_RECURSSION
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в игру Крестики-Нолики!");

			do
			{
				//Отрисовка текущего состояния игрового поля
				DrawBoard();
				//Ход игрока
				MakeMove();
			} while (!CheckForWinner() && !CheckForDraw()); // Пока нет победителя и нет ничьи

			DrawBoard(); // Отрисовка конечного состояния игрового поля
			//Проверка на наличие победителя
			if (CheckForWinner())
			{
				if (player1Turn)
				{
					Console.WriteLine("Игрок 2 выиграл!");
				}
				else
				{
					Console.WriteLine("Игрок 1 выиграл!");
				}
			}
			//Если нет победителя, то ничья
			else
			{
				Console.WriteLine("Ничья!");
			}

			Console.ReadLine();
		}
#endif
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в игру Крестики-Нолики!");

			PlayGame();

			Console.ReadLine();
		}

		static void PlayGame()
		{
			DrawBoard();
			MakeMove();

			if (!CheckForWinner() && !CheckForDraw()) // Пока нет победителя и нет ничьи
			{
				PlayGame(); // Рекурсивный вызов PlayGame для продолжения игры
			}
			else
			{
				DrawBoard();

				if (CheckForWinner())
				{
					if (player1Turn)
					{
						Console.WriteLine("Игрок 2 выиграл!");
					}
					else
					{
						Console.WriteLine("Игрок 1 выиграл!");
					}
				}
				else
				{
					Console.WriteLine("Ничья!");
				}
			}
		}

	// Метод отрисовки игрового поля
	static void DrawBoard()
		{
			Console.Clear();
			Console.WriteLine("  {0} | {1} | {2}", board[0], board[1], board[2]);
			Console.WriteLine("-------------");
			Console.WriteLine("  {0} | {1} | {2}", board[3], board[4], board[5]);
			Console.WriteLine("-------------");
			Console.WriteLine("  {0} | {1} | {2}", board[6], board[7], board[8]);
		}

		// Метод для осуществления хода игрока
		static void MakeMove()
		{
			int index;
			do
			{
				Console.WriteLine($"Игрок {(player1Turn ? "1" : "2")}, выберите свободную клетку от 1 до 9:");
				index = int.Parse(Console.ReadLine()) - 1;
			} while (index < 0 || index >= 9 || !Char.IsDigit(board[index])); // Проверка на корректность введенных данных
			// Установка крестика или нолика в выбранную клетку
			board[index] = player1Turn ? 'X' : 'O';
			// Смена очередности игроков
			player1Turn = !player1Turn;
		}

		// Метод для проверки наличия победителя наверное есть какой то попроще но у меня так
		static bool CheckForWinner()
		{
			if ((board[0] == board[1] && board[1] == board[2]) ||
				(board[3] == board[4] && board[4] == board[5]) ||
				(board[6] == board[7] && board[7] == board[8]) ||
				(board[0] == board[3] && board[3] == board[6]) ||
				(board[1] == board[4] && board[4] == board[7]) ||
				(board[2] == board[5] && board[5] == board[8]) ||
				(board[0] == board[4] && board[4] == board[8]) ||
				(board[2] == board[4] && board[4] == board[6]))
			{
				return true; // Если есть победитель, вернуть true
			}

			return false; // В противном случае вернуть false
		}

		// Метод для проверки ничьи
		static bool CheckForDraw()
		{
			//foreach перебирает элементы в массиве, cell поочередно принимает значение каждого элемента из массива board. Так каждая клетка поля проверяется на наличие символа
			foreach (char cell in board)
			{
				// Проверка на наличие свободных клеток
				if (Char.IsDigit(cell))
				{
					return false; // Если есть свободная клетка, вернуть false
				}
			}

			return true; // В противном случае, вернуть true
		}
	}
}
	
