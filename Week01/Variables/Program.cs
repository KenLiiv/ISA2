using System;

namespace Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			string myFirstName;
			string myLastName;

			Console.WriteLine("Type your first name: ");
			myFirstName = Console.ReadLine();
			Console.WriteLine("Type your last name: ");
			myLastName = Console.ReadLine();
			Console.WriteLine("Your name is " + myFirstName + " " + myLastName);
			Console.ReadKey(); // teeb sama mis ReadLine
		}
	}
}
