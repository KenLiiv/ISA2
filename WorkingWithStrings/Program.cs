﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			//string myString = "My \"so-called\" life";
			//string myString = "What if i need a \nnew line?";
			//string myString = "GO to your c:\\ drive";
			//string myString = @"Go to your c:\ drive";

			//string myString = String.Format("{1} = {0}", "First", "Seconds");

			//string myString = string.Format("{0:C}", 123.45);
			//string myString = string.Format("{0:N}", 1234567890);
			//string myString = string.Format("Percentage: {0:P}", .123);
			//string myString = string.Format("Phone number: {0:(###) ###-####", 123456789012);
			//string myString = "To be or not to be";

			//myString = myString.Substring(3, 2);
			//myString.ToUpper();
			//myString.Replace(" ", "-");
			//myString.Remove(3, 3);

			//myString = String.Format("Length before: {0} and length after: {1}", myString.Length, myString.Trim().Length);
			/*
			for (int i = 0; i < 100; i++)
			{
				myString += "-" + i.ToString();
			}
			*/
			StringBuilder myString = new StringBuilder();

			for (int i = 0; i < 100; i++)
			{
				myString.Append("-");
				myString.Append(i);
			}
			Console.WriteLine(myString);
			Console.ReadLine();
		}
	}
}
