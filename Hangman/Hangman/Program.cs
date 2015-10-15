using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            int health = 2;
            string running = "";
            List<string> words = new List<string>()
            {
                "computer", "laptop", "programming", "language", "processor", "bug", "error"
            };

            string word = words[rnd.Next(0, words.Count)];

            Console.WriteLine(getNoose(1));

            foreach (char c in word)
                Console.Write("_");

            while (true)
            {
                Console.WriteLine();
                string input = Console.ReadLine();

                if (running.Contains(input))
                {
                    Console.WriteLine("Character was already guessed!");
                    continue;
                }

                if (word.Contains(input))
                {
                    for (int x = 0; x < word.Length; x++)
                    {
                        if (running.Contains(word[x].ToString()))
                            Console.Write(word[x].ToString());
                        else if (word[x].ToString() == input)
                            Console.Write(word[x].ToString());
                        else
                            Console.Write("_");
                    }

                    running += input;
                }
                else
                {
                    if (health >= 7)
                    {
                        Console.WriteLine("The correct word was: " + word + ". You died!");
                        Environment.Exit(0);
                    }

                    Console.WriteLine(getNoose(health++));
                    for (int x = 0; x < word.Length; x++)
                    {
                        if (running.Contains(word[x].ToString()))
                            Console.Write(word[x].ToString());
                        else
                            Console.Write("_");
                    }
                }
            }
        }

        private static string getNoose(int position)
        {
            switch (position)
            {
                case 1:
                    return Positions.one;
                case 2:
                    return Positions.two;
                case 3:
                    return Positions.three;
                case 4:
                    return Positions.four;
                case 5:
                    return Positions.five;
                case 6:
                    return Positions.six;
                case 7:
                    return Positions.seven;
                default:
                    return Positions.one;
            }
        }
    }
}
