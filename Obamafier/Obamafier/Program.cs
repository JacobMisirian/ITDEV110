using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obamafier
{
    class Program
    {
        static void Main(string[] args)
        {
            Info assignmentInfo = new Info("DollarsNChange");
            assignmentInfo.DisplayInfo();

            Console.Write("\n\nEnter a dollar amount in [DOLLARS].[CENTS]  ");
            makeChange(Console.ReadLine());
            Console.Read();
        }

        private static void makeChange(string money)
        {
            double amount = Convert.ToDouble(money);
            Console.WriteLine("Quarters: " + Math.Floor(amount / .25));
            amount %= .25;
            Console.WriteLine("Dimes: " + Math.Floor(amount / .1));
            amount %= .10;
            Console.WriteLine("Nickles: " + Math.Floor(amount / .05));
            amount %= .05;
            Console.WriteLine("Pennies: " + Math.Floor(amount / .01));
        }
    }
}
