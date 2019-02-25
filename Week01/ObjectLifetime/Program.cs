using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Car myCar = new Car();

			/*
			myCar.Make = "Audi";
			myCar.Model = "A4";
			myCar.Year = 2017;
			myCar.Color = "Pink";
			
			Car myThirdCar = new Car("Nissan", "Primera", 2004, "Pink");

			Console.WriteLine("{0} {1} {2} {3}", 
				myCar.Make,
				myCar.Model,
				myCar.Year,
				myCar.Color);

			Car myOtherCar;
			myOtherCar = myCar;

			//myOtherCar = null;

			Console.WriteLine("{0} {1} {2} {3}",
				myOtherCar.Make,
				myOtherCar.Model,
				myOtherCar.Year,
				myOtherCar.Color);
			myOtherCar.Model = "oo";
			*/
			Car.TestMethod();
			Console.ReadLine();
		}
	}
	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public Car()
		{
			Make = "defaultMaker";
		}
		public Car(string make, string model, int year, string color)
		{
			Make = make;
			Model = model;
			Year = year;
			Color = color;
		}
		public static void TestMethod()
		{
			Console.WriteLine("Static method called");

			//wont work as an instance of this class has not been made
			//Console.WriteLine(Make);
		}
	}
}
