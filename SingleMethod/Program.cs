using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("First name: ");
			string firstName = Console.ReadLine();

			Console.Write("Last name: ");
			string lastName = Console.ReadLine();

			Console.WriteLine("City: ");
			string city = Console.ReadLine();

			DisplayResult(ReverseString(firstName), 
				ReverseString(lastName), 
				ReverseString(city));

			Console.WriteLine();

			DisplayResult(ReverseString(firstName) + " " +
				ReverseString(lastName) + " " +
				ReverseString(city));

			Console.ReadLine();
		}
		private static string ReverseString(string message)
		{
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
		}
		private static void DisplayResult(string reversedFirstName, 
			string reversedLastName, 
			string reversedCity)
		{
			Console.Write("Results: ");
			Console.Write(String.Format("{0} {1} {2}",
				reversedFirstName,
				reversedLastName,
				reversedCity));
		}
		private static void DisplayResult(string message)
		{
			Console.Write("Results: ");
			Console.Write(message);
		}
	}
}
