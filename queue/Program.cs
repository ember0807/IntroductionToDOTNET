using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace queue
{
	//Alt + Tab использует  стек (stack) для хранения информации о последних использованных приложениях.
	//	Стек - это структура данных, работающая по принципу "последний вошел, первый вышел" , что идеально подходит для передачи фокуса от одного окна к другому в порядке,
	//	обратном тому, в котором они открывались или использовались.


	internal class Program
	{
		public class Node  // Класс, представляющий узел односвязного списка
		{
			public int data; // Хранит значение узла
			public Node next; // Ссылка на следующий узел
		}

		public class Stack // Класс, представляющий стек
		{
			private Node top; // Вершина стека

			public void Push(int value) // Метод для добавления элемента в стек
			{
				Node newNode = new Node(); // Создаем новый узел
				newNode.data = value; // Присваиваем ему значение
				newNode.next = top; // Устанавливаем ссылку на предыдущую вершину
				top = newNode; // Делаем новый узел новой вершиной
			}

			public int Pop() // Метод для удаления и возврата верхнего элемента из стека
			{
				if (top == null) // Проверяем, пуст ли стек
				{
					throw new InvalidOperationException("Стек пуст"); // Выбрасываем исключение, если стек пуст
				}
				int value = top.data; // Получаем значение верхнего элемента
				top = top.next; // Перемещаем вершину на предыдущий элемент
				return value; // Возвращаем значение верхнего элемента
			}

			public int Peek() // Метод для получения значения верхнего элемента без удаления
			{
				if (top == null) // Проверяем, пуст ли стек
				{
					throw new InvalidOperationException("Стек пуст"); // Выбрасываем исключение, если стек пуст
				}
				return top.data; // Возвращаем значение верхнего элемента
			}

			public bool IsEmpty() // Метод для проверки, пуст ли стек
			{
				return top == null; // Возвращаем true, если стек пуст, иначе false
			}
		}

		public class Node2
		{
			public int data;
			public Node2 next;
			public Node2 prev;
		}
		public class Queue
		{
			private Node2 front;
			private Node2 rear;

			public void Enqueue(int value)
			{
				Node2 newNode2 = new Node2();
				newNode2.data = value;
				newNode2.next = null;
				if (rear != null)
				{
					newNode2.prev = rear;
					rear.next = newNode2;
				}
				rear = newNode2;
				if (front == null)
				{
					front = rear;
				}
			}

			public int Dequeue()
			{
				if (front == null)
				{
					throw new InvalidOperationException("Очередь пуста");
				}
				int value = front.data;
				front = front.next;
				if (front != null)
				{
					front.prev = null;
				}
				else
				{
					rear = null;
				}
				return value;
			}

			public int Peek()
			{
				if (front == null)
				{
					throw new InvalidOperationException("Очередь пуста");
				}
				return front.data;
			}

			public bool IsEmpty()
			{
				return front == null;
			}
		}
			static void Main(string[] args)
		{
			// Пример использования Stack со случайными значениями
			Console.WriteLine("Пример использования Stack со случайными значениями:");
			Stack stack = new Stack();
			Random random = new Random();

			// Добавляем случайные значения в стек
			for (int i = 0; i < 5; i++)
			{
				int value = random.Next(1, 101);
				stack.Push(value);
				Console.WriteLine($"Добавлено в стек: {value}");
			}

			// Извлекаем значения из стека с помощью Pop
			Console.WriteLine("\nИзвлечение из стека с помощью Pop:");
			while (!stack.IsEmpty())
			{
				Console.WriteLine($"Извлечено из стека: {stack.Pop()}");
			}


			// Пример использования очереди 
			Console.WriteLine("\nПример использования очереди:");
			Queue queue = new Queue();

			// Добавляем случайные значения в очередь
			for (int i = 0; i < 5; i++)
			{
				int value = random.Next(1, 101);
				queue.Enqueue(value);
				Console.WriteLine($"Добавлено в очередь: {value}");
			}

			// Извлекаем значения из очереди с помощью Dequeue
			Console.WriteLine("\nИзвлечение из очереди с помощью Dequeue:");
			while (!queue.IsEmpty())
			{
				Console.WriteLine($"Извлечено из очереди: {queue.Dequeue()}");
			}
		}
	}
}

