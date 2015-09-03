using System;

namespace Assignment1A
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			DisplayInfo();
		}

		public static void DisplayInfo()
		{
			Console.WriteLine("Jacob Misirian");
			Console.WriteLine("ITDEV 110");
			Console.WriteLine("Bob Menzl");
			Console.WriteLine("Assignment 1a");
			Console.WriteLine(DateTime.Today.ToString("d"));
		}
	}
}
