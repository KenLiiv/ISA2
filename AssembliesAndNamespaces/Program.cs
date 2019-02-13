using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "What a nice message!";
			File.WriteAllText(@"WriteText.txt", text);

			WebClient client = new WebClient();
			string reply = client.DownloadString("http://msdn.microsoft.com");

			Console.WriteLine(reply);
			Console.WriteLine("Hello world!");
			Console.ReadLine();
		}
	}
}
