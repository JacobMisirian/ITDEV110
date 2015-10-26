using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperations
{
    public class MathOperationsUI
    {
        public MathOperationsUI()
        {
        }

        public int DisplayMenu(params string[] args)
        {
            int choice = 0;
            for (int x = 0; x < args.Length; x++)
                Console.WriteLine(x + ". " + args[x]);
            try
            {
                choice = Convert.ToInt32(Console.ReadLine().ToString());
            }
            catch
            {
                Console.WriteLine("Must enter a valid choice!");
                return DisplayMenu(args);
            }
            if (choice > args.Length || choice < 0)
            {
                Console.WriteLine("Must enter a valid choice! Entered " + choice);
                return DisplayMenu(args);
            }

            return choice;
        }

        private int promptForInteger()
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int result = 0;

            try
            {
                result = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Input was not in correct integer format!");
                return promptForInteger();
            }

            return result;
        }

        public double ProcessMenu(int choice, MathOperations ops)
        {
            ops.FirstOperand = promptForInteger();
            ops.SecondOperand = promptForInteger();

            switch (choice)
            {
                case 0:
                    return ops.Addition();
                case 1:
                    return ops.Subtraction();
                case 2:
                    return ops.Multiplication();
                case 3:
                    return ops.Division();
                default:
                    throw new Exception("Something went very wrong here");
            }
        }
    }
}
