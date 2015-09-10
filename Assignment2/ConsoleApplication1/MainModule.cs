using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MainModule
    {
        static void Main(string[] args)
        {
            new Info().DisplayInfo();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("String\tBinary\tHex\tOctal\tDecimal");

            foreach (char c in name)
            {
                new FormattedOutput(c).DisplayLetter();
            }

            Console.Read();
        }
    }
}
