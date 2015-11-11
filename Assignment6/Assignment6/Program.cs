using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            new Info("Assignment6").DisplayInfo();

            UserInterface ui = new UserInterface();
            ui.DisplayInstructions();
            ui.DisplayResults(new Numeral(ui.PromptForInteger(1, 10)).ConvertToNumeral());

            Console.Read();
        }
    }
}
