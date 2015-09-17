using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtoC
{
    class Program
    {
        private static double farenheit { get; set; }

        static void Main(string[] args)
        {
            farenheit = prompt();
            displayCelsius(calculate());

            Console.ReadKey();
        }

        private static double prompt()
        {
            Console.Write("Enter a temperature in farenheit to convert to celsius: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double calculate()
        {
            return (farenheit - 32) / 1.8;
        }

        private static void displayCelsius(double celsius)
        {
            Console.WriteLine("Original was: " + farenheit);
            Console.WriteLine("In Celsius: " + celsius.ToString("N1") + "°C");
        }
    }
}
