using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string content = File.ReadAllText("nonexistentfile.txt");
				Console.WriteLine(content);
				Console.ReadLine();
			}
#pragma warning disable CS0168 // Variable is declared but never used
			catch(FileNotFoundException ex)
#pragma warning restore CS0168 // Variable is declared but never used
			{
				Console.WriteLine("File not found, make sure file is there!");
				Console.WriteLine("Example file name: nonexistentfile.txt");
			}
#pragma warning disable CS0168 // Variable is declared but never used
			catch(DirectoryNotFoundException ex)
#pragma warning restore CS0168 // Variable is declared but never used
			{
				Console.WriteLine("Could not find the directory!!");
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error!");
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Closing application now...");
			}
			Console.ReadLine();
		}
	}
}
