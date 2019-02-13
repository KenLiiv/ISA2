using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Car car1 = new Car();
			car1.Make = "Audi";
			car1.Model = "A6";
			car1.VIN = "A1";

			Car car2 = new Car();
			car2.Make = "Nissan";
			car2.Model = "Primera";
			car2.VIN = "A2";

			Book b1 = new Book();
			b1.Author = "";
			b1.Title = "";
			b1.ISBN = "";
			*/
			/*
			ArrayList carList = new ArrayList();
			carList.Add(car1);
			carList.Add(car2);
			carList.Add(b1);
			carList.Remove(b1);
			foreach(Car car in carList)
			{
				Console.WriteLine(car.Make);
			}
			*/
			/*
			List<Car> carList = new List<car>();
			carList.Add(car1);
			carList.Add(car2);
			//carList.Add(b1);
			foreach(Car car in carList)
			{
				Console.WriteLine(car.Model);
			}
			*/
			/*
			Dictionary<string, Car> carDict = new Dictionary<string, Car>();
			carDict.Add(car1.VIN, car1);
			carDict.Add(car2.VIN, car2);

			Console.WriteLine(carDict["A1"].Make);
			*/
			//string[] names = { "Mati", "Gunnar", "Indrek" };

			//Car car1 = new Car() { Make = "BMW", Model = "320", VIN = "A3" };
			//Car car2 = new Car() { Make = "Nissan", Model = "Ultima", VIN = "A4" };

			List<Car> carList = new List<Car>()
			{
				new Car {Make = "BMW", Model = "320", VIN = "A5"},
				new Car { Make = "Nissan", Model = "Ultima", VIN = "A6" }
			};

			Console.ReadLine();
		}
	}
	class Car
	{
		public string VIN { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
	}
	class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
	}
}
