//#define SINGLE_DIMENSIONAL_ARRAYS
//#define MULTI_DIMENSIONAL_ARRAYS
//#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main()
		{
			Random random = new Random();

			// Одномерный массив
			int[] one_dimension = new int[5];
			for (int i = 0; i < one_dimension.Length; i++)
			{
				one_dimension[i] = random.Next(1, 21);
			}

			Console.WriteLine("Одномерный массив:");
			Console.WriteLine($"Массив: {string.Join(", ", one_dimension)}");

			// Двумерный массив
			int[,] two_dimensions = new int[2, 3];
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					two_dimensions[i, j] = random.Next(1, 21);
				}
			}

			Console.WriteLine("\nДвумерный массив:");
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"{two_dimensions[i, j]} ");
				}
				Console.WriteLine();
			}

			// Зубчатый массив
			int[][] different_dimensions = new int[][]
			{
			new int[random.Next(1, 6)], // случайное количество элементов в первом массиве
            new int[random.Next(1, 6)], // случайное количество элементов во втором массиве
            new int[random.Next(1, 6)]  // случайное количество элементов в третьем массиве
			};

			for (int i = 0; i < different_dimensions.Length; i++)
			{
				for (int j = 0; j < different_dimensions[i].Length; j++)
				{
					different_dimensions[i][j] = random.Next(1, 21);
				}
			}
			//string.Join(", ", arr) - Этот метод объединяет элементы массива arr в одну строку, разделяя их запятой и пробелом.
			//Таким образом, каждый элемент массива будет отображаться через запятую с пробелом.
			Console.WriteLine("\nЗубчатый массив:");
			foreach (var array in different_dimensions)
			{
				Console.WriteLine(string.Join(", ", array));
			}


			//выводы
			// Одномерный массив
			string oneDimensionOutput = $"Одномерный массив:   Сумма: {one_dimension.Sum()}   Среднее: {one_dimension.Average()}   Минимальное: {one_dimension.Min()}   Максимальное: {one_dimension.Max()}";
			Console.WriteLine(oneDimensionOutput);
			// Двумерный массив
			//Cast<int>() - это метод, который преобразует каждый элемент массива в указанный тип данных, в данном случае - в целое число (int).
			//Если элементы уже являются целыми числами, то Cast<int>() будет использоваться для явного приведения типа.
			string twoDimensionOutput = $"Двумерный массив:    Сумма: {two_dimensions.Cast<int>().Sum()}   Среднее: {two_dimensions.Cast<int>().Average()}   Минимальное: {two_dimensions.Cast<int>().Min()}   Максимальное: {two_dimensions.Cast<int>().Max()}";
			Console.WriteLine(twoDimensionOutput);
			// Зубчатый массив

			//SelectMany() - это метод LINQ, который выполняет проекцию и объединение результатов. Он принимает функцию, которая определяет, что делать с каждым элементом массива.
			//SelectMany(arr => arr) берет каждый вложенный массив из different_dimensions и объединяет их в одну последовательность.
			//Например, если different_dimensions содержит вложенные массивы [1, 2, 3] и [4, 5, 6], то SelectMany() вернет последовательность [1, 2, 3, 4, 5, 6].
			string differentDimensionOutput = $"Зубчатый массив:     Сумма: {different_dimensions.SelectMany(arr => arr).Sum()}   Среднее: {different_dimensions.SelectMany(arr => arr).Average()}   Минимальное: {different_dimensions.SelectMany(arr => arr).Min()}   Максимальное: {different_dimensions.SelectMany(arr => arr).Max()}";
			Console.WriteLine(differentDimensionOutput);

			// Создаем словарь для хранения количества повторений каждого значения
			Dictionary<int, int> repetitions = new Dictionary<int, int>();
			// Подсчитываем повторения каждого значения
			

		}
	}
}



		//static void Main(string[] args)
		//{
		//	Random rand = new Random();
#if SINGLE_DIMENSIONAL_ARRAYS
			Console.WriteLine("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(-100, 100);
			}
			//foreach (ref int i in arr)
			//{
			//	i = rand.Next();
			//}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i] + "\t");
			}
			Console.WriteLine();
			foreach (int i in arr)
			{
				Console.WriteLine(i + "\t");
			}
			Console.WriteLine();
#endif
#if MULTI_DIMENSIONAL_ARRAYS
			int rows, cols;
			Console.WriteLine("Введите количество строк: ");
			rows = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ввекдите количество столбцов: ");
			cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];
			Console.WriteLine($"Колличество измерений: {i_arr_2.Rank}");
			for (int i = 0; i < i_arr_2.GetLength(0); i++) 
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++) 
				{
					i_arr_2[i,j] = rand.Next(-100, 100);
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			foreach (int i in i_arr_2)
			{ 
				Console.WriteLine(i+"\t");
			}
			Console.WriteLine();
#endif

#if JAGGED_ARRAYS
			int rows = 5;
			int[][] i_arr_j = new int[][]
			{ 
				new int[] { 0, 1, 1, 2 },
				new int[] { 3, 5, 8, 13,21 },
				new int[] { 34, 55, 89 },
				new int[] { 144, 233, 377 }
			};
			for(int i = 0; i<i_arr_j.Length; i++) 
			{
				for(int j = 0; j < i_arr_j[i].Length; j++) 
				{
					Console.Write(i_arr_j[i][j] + "\t");
				}
				Console.WriteLine();
			}
#endif
		//}
		//}
	//}
