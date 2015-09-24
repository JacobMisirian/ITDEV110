using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obamafier
{
    public class Info
    {
        private string assignmentName;

        public Info(string assignmentName)
        {
            this.assignmentName = assignmentName;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name:\tJacob Misirian");
            Console.WriteLine("Class:\tITDEV 110");
            Console.WriteLine("Teacher:\tBob Menzl");
            Console.WriteLine("Assignment:\t" + this.assignmentName);
            Console.WriteLine("Date:\t" + DateTime.Today.ToString("d"));
        }
    }
}
