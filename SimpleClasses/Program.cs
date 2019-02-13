using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.Make = "Audi";
			myCar.Model = "A4";
			myCar.Year = 2017;
			myCar.Color = "Pink";
			Console.WriteLine("{0} {1} {2} {3}", myCar.Make, 
				myCar.Model,
				myCar.Year,
				myCar.Color);

			Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
		}
		private static decimal DetermineMarketValue(Car car)
		{
			decimal carValue = 10000;
			return carValue;
		}
	}
	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public decimal DetermineMarketValue()
		{
			decimal carValue;
			if(Year > 1990)
			{
				carValue = 10000;
			}
			else
			{
				carValue = 5000;
			}
			return carValue;
		}
	}
}
