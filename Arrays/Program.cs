//#define SINGLE_DIMENSIONAL_ARRAYS
//#define MULTI_DIMENSIONAL_ARRAYS
#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
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
		}
	}
}
