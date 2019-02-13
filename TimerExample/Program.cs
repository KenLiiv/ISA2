using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Timer myTimer = new Timer(2000);

			myTimer.Elapsed += MyTimer_Elapsed;
			myTimer.Elapsed += MyTimer_Elapsed1;

			myTimer.Start();

			Console.WriteLine("Press enter to remove the blue one");
			Console.ReadLine();

			myTimer.Elapsed -= MyTimer_Elapsed;
		}

		private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Elapsed1: {0:MM:ss.fff}", e.SignalTime);
		}

		private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Elapsed: {0:MM:ss.fff}", e.SignalTime);
		}
	}
}
