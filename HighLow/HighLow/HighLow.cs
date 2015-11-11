using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    public enum Comparison
    {
        Greater,
        Lesser,
        Equal,
        OutOfBounds
    }

    public class HighLow
    {
        private int lowerBound { get; set; }
        private int upperBound { get; set; }

        private int correctNumber { get; set; }

        public HighLow(int lowerBound = 0, int upperBound = 100)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;

            this.correctNumber = new Random().Next(lowerBound, upperBound);
        }

        public Comparison CompareGuess(int guess)
        {
            if (guess < lowerBound || guess > upperBound)
                return Comparison.OutOfBounds;
            if (guess > correctNumber)
                return Comparison.Greater;
            if (guess < correctNumber)
                return Comparison.Lesser;
            return Comparison.Equal;
        }
    }
}
