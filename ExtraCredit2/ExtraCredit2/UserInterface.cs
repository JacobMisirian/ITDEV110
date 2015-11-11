using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit2
{
    public class UserInterface
    {
        public UserInterface()
        {
        }

        public int DisplayMenu(params string[] args)
        {
            for (int x = 0; x < args.Length; x++)
                Console.WriteLine(x + ". " + args[x]);
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0 || input > args.Length - 1)
            {
                Console.WriteLine("Enter a valid choice please.");
                return DisplayMenu(args);
            }

            return input;
        }

        public double PromptForDouble(string prompt = "")
        {
            Console.Write(prompt);
            double ret = 0;

            try
            {
                ret = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input was not in the correct format!");
                return PromptForDouble(prompt);
            }

            return ret;
        }
    }
}
