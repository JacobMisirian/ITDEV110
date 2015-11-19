using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    public class HighLowUI
    {
        private int lowerBound { get; set; }
        private int upperBound { get; set; }
        private int tries { get; set; }
        private HighLow game { get; set; }

        public static Difficulty PromptForDifficulty(params string[] args)
        {
            for (int x = 0; x < args.Length; x++)
                Console.WriteLine(x + ". " + args[x]);
            int choice = promptForInt("Difficulty: ");
            if (choice >= args.Length)
            {
                Console.WriteLine("Enter a number between 0 and " + (args.Length - 1));
                return PromptForDifficulty(args);
            }

            switch (choice)
            {
                case 0:
                    return Difficulty.Easy;
                case 1:
                    return Difficulty.Medium;
                case 2:
                    return Difficulty.Hard;
                default:
                    throw new Exception("Something has gone horribly wrong!");
            }
        }

        public HighLowUI(int lowerBound, int upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.tries = 0;

            this.game = new HighLow(lowerBound, upperBound);
        }

        public void Play()
        {
            while (true)
            {
                switch (game.CompareGuess(promptForInt("Enter a number between " + lowerBound + " and " + upperBound + ": ")))
                {
                    case Comparison.Equal:
                        Console.WriteLine("You won and it only took you " + ++tries + " tries! Play again? y/n ");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "y")
                            new HighLowUI(lowerBound, upperBound).Play();
                        Environment.Exit(0);
                        break;
                    case Comparison.Greater:
                        Console.WriteLine("Too high!");
                        break;
                    case Comparison.Lesser:
                        Console.WriteLine("Too low!");
                        break;
                    case Comparison.OutOfBounds:
                        Console.WriteLine("Number was not in bounds you fool!");
                        break;
                }
                tries++;
            }
        }

        private static int promptForInt(string prompt = "")
        {
            Console.Write(prompt);
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter a valid number!");
                return promptForInt(prompt);
            }
            return choice;
        }
    }
}
