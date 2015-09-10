using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Info
    {
        public Info()
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name:\tJacob Misirian");
            Console.WriteLine("Class:\tITDEV 110");
            Console.WriteLine("Teacher:\tBob Menzl");
            Console.WriteLine("Assignment:\tAssignment #2");
            Console.WriteLine("Date:\t" + DateTime.Today.ToString("d"));
        }
    }
}
