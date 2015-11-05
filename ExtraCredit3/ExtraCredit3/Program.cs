using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraCredit3
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            int lowest = -1;
            int highest = -1;
            int oddCounter = 0;

            for (int x = 0; x < 1000; x++)
            {
                int number = random.Next(0, 100001);
                if (number % 2 != 0)
                    oddCounter++;
                if (lowest == -1 || lowest > number)
                    lowest = number;
                if (highest < number)
                    highest = number;
            }

            MessageBox.Show("Highest: " + highest + ".Lowest: " + lowest + ". Number of odd numbers: " + oddCounter);
        }
    }
}
