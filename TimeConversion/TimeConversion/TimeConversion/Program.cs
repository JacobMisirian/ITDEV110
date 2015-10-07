using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            new Info("TimeConversion").DisplayInfo();

            Console.Write("\n\nEnter an amount of seconds: ");
            int seconds = getSeconds();

            int hours = toHours(seconds);
            seconds = seconds - hours * 3600;
            int minutes = toMinutes(seconds);
            seconds = seconds - minutes * 60;

            showResults(new int[] { seconds, minutes, hours });

            Thread.Sleep(Timeout.Infinite);
        }

        private static int getSeconds()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int toHours(int seconds)
        {
            return seconds / 3600;
        }

        private static int toMinutes(int seconds)
        {
            return seconds / 60;
        }

        private static void showResults(int[] args)
        {
            Console.WriteLine("Totals\nSeconds: " + args[0] + "\tMinutes: " + args[1] + "\tHours: " + args[2]);
        }
    }
}
