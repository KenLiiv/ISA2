using System;

namespace Decisions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Big giveaway!");
			Console.Write("Choose a door (1, 2 or 3): ");
			string userValue = Console.ReadLine();

			/*if(uservalue == "1")
				message = "You won a new car!";
			else if (uservalue == "2")
				message = "You won a new boat!";
			else if (uservalue == "3")
				message = "You won a new cat!";
			else
			{
				message = "Did not understand!";
			}
			Console.WriteLine(message);*/
			string message = (userValue == "1") ? "boat" : "strand of lint";
			Console.WriteLine("You entered {0}, therefore you won a {1}.", userValue, message);
			Console.ReadLine();
		}
	}
}
