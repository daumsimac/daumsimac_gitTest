using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string greeting = "           Hello World!        ";
			Console.WriteLine($"[{greeting}]");

			string trimmedGreeting = greeting.TrimStart();
			Console.WriteLine($"[{ trimmedGreeting}]");

			trimmedGreeting = greeting.TrimEnd();
			Console.WriteLine($"[{ trimmedGreeting}]");

			trimmedGreeting = greeting.Trim();
			Console.WriteLine($"[{ trimmedGreeting}]");

			Console.WriteLine("This is a test!!!");
		}
	}
}
