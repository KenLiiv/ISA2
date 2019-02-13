using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			/*int[] numbers = new int[5];
			numbers[0] = 2;
			numbers[1] = 6;
			//Console.WriteLine(numbers[0]);
			Console.WriteLine(numbers.Length);*/

			//int[] numbers = new int[] { 2, 5, 7, 12 };

			string[] names = new string[] { "Ken", "Gunnar", "Mihkel", "Toots" };
			/*
			for (int i = 0; i < names.Length - 1; i++)
			{
				Console.WriteLine(names[i]);
			}
			Console.ReadLine();
			*/
			/*
			foreach(string name in names)
			{
				Console.WriteLine(name);
			}
			Console.ReadLine();
			*/
			string quote = "To be or not to be";
			char[] charArray = quote.ToCharArray();
			Array.Reverse(charArray);
			foreach(char c in charArray)
			{
				Console.Write(c);
			}
			Console.ReadLine();
		} 
	}
}
