using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
	 class Tree
	{
		public class Element
		{
			public int Data;
			public Element pLeft;
			public Element pRight;
			public Element(int Data, Element pLeft = null, Element pRight = null)
			{ 
				this.Data = Data;
				this.pLeft = pLeft;
				this.pRight = pRight;
				Console.WriteLine($"EConstructor : \t {GetHashCode()}");
			}
			~Element() 
			{
				Console.WriteLine($"EDestructor: {GetHashCode()}");
			}
		}
		public int MinValue()
		{
			return FindMinValue(Root);
		}

		private int FindMinValue(Element node)
		{
			if (node.pLeft == null)
				return node.Data;
			else
				return FindMinValue(node.pLeft);
		}
		public int MaxValue()
		{
			return FindMaxValue(Root);
		}

		private int FindMaxValue(Element node)
		{
			if (node.pRight == null)
				return node.Data;
			else
				return FindMaxValue(node.pRight);
		}
		public int Count()
		{
			return CountNodes(Root);
		}

		private int CountNodes(Element node)
		{
			if (node == null)
				return 0;
			else
				return 1 + CountNodes(node.pLeft) + CountNodes(node.pRight);
		}
		public int Sum()
		{
			return CalculateSum(Root);
		}

		private int CalculateSum(Element node)
		{
			if (node == null)
				return 0;
			else
				return node.Data + CalculateSum(node.pLeft) + CalculateSum(node.pRight);
		}

		public double Avg()
		{
			return (double)Sum() / Count();
		}
		public Element Root;
			public Tree()
		{ 
			Console.WriteLine($"TConstructor: {GetHashCode()}");
		}
		~Tree() 
		{ 
			Console.WriteLine($"TDestructor: {GetHashCode()}");
		}
		public void insert(int Data,Element Root)
		{
			if (this.Root == null) this.Root = new Element(Data);
			if (Root == null) return;
			if (Data < Root.Data)
			{
				if (Root.pLeft == null) Root.pLeft = new Element(Data);
				else insert(Data, Root.pLeft);
			}
			else
			{ 
			if(Root.pRight == null) Root.pRight = new Element(Data);
				else insert(Data, Root.pRight);
			}
		}

		public void Print(Element Root)
		{
			if (Root == null) return;
			Print(Root.pLeft);
			Console.Write($"{Root.Data}\t");
			Print(Root.pRight);
		
		}
	}
	class Program
	{
		static void Main(string[] args)
		{ 
			Random rand = new Random(0);
			Console.WriteLine("Введите размер дерева: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Tree tree = new Tree();
			for (int i = 0; i < n; i++)
			{
				tree.insert(rand.Next(100), tree.Root);
			}
			tree.Print(tree.Root);

			int min = tree.MinValue();
			int max = tree.MaxValue();
			int count = tree.Count();
			int sum = tree.Sum();
			double avg = tree.Avg();
			
			Console.WriteLine($"\n\nМинимальное значение: {min}");
			Console.WriteLine($"Максимальное значение: {max}");
			Console.WriteLine($"Количество элементов: {count}");
			Console.WriteLine($"Сумма элементов: {sum}");
			Console.WriteLine($"Среднее арифметическое: {avg}\n");
		}
	}

}
