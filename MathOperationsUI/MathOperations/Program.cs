using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperationsUI ui = new MathOperationsUI();
            Console.WriteLine(ui.ProcessMenu(ui.DisplayMenu("Addition", "Subtraction", "Multiplication", "Division"), new MathOperations()));

            Console.Read();
        }
    }
}
