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
			Console.WriteLine("Name:\tJacob Misirian");
			Console.WriteLine("Class:\tITDEV 110");
			Console.WriteLine("Teacher:\tBob Menzl");
			Console.WriteLine("Assignment:\tAssignment 1a");
			Console.WriteLine("Date:\t" + DateTime.Today.ToString("d"));
		}
	}
}
