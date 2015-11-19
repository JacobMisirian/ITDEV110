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

            int upperBound = 0;
            switch (HighLowUI.PromptForDifficulty("Easy.", "Medium.", "Hard."))
            {
                case Difficulty.Easy:
                    upperBound = 10;
                    break;
                case Difficulty.Medium:
                    upperBound = 50;
                    break;
                case Difficulty.Hard:
                    upperBound = 100;
                    break;
            }
            new HighLowUI(0, upperBound).Play();
        }
    }
}
