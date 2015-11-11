using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            new Info("Assignment 7").DisplayInfo();
            new HighLowUI(0, 100).Play();
        }
    }
}
