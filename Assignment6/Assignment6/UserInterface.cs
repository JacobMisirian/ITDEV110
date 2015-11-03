using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6
{
    public class UserInterface
    {
        public UserInterface()
        {
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("Enter a number between 1 and 10 and we will convert it to Roman numerals.");
        }

        public int PromptForInteger(int lower, int upper)
        {
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input was not in the correct format!");
                return PromptForInteger(lower, upper);
            }

            if (choice < lower || choice > upper)
            {
                Console.WriteLine("Enter a choice between " + lower + " and " + upper);
                return PromptForInteger(lower, upper);
            }

            return choice;
        }

        public void DisplayResults(string numeral)
        {
            Console.WriteLine("The roman numeral is: " + numeral);
        }
    }
}
