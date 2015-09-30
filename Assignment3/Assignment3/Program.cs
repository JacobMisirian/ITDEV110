using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Info("Assignment3").DisplayInfo();

            Console.WriteLine(add(3, 2)); // Expected 5
            Console.WriteLine(subtract(6, 4, 1)); // Expected 1
            Console.WriteLine(multiply(4, 5, 2, 3)); // Expected 120
            Console.WriteLine(divide(30, 2, 5)); // Expected 3
            Console.WriteLine(modulus(40, 3)); // Expected 1

            Console.ReadKey();
        }

        private static double add(params double[] args)
        {
            double total = args[0];
            for (int x = 1; x < args.Length; x++)
                total += args[x];

            return total;
        }
        private static double subtract(params double[] args)
        {
            double total = args[0];
            for (int x = 1; x < args.Length; x++)
                total -= args[x];

            return total;
        }
        private static double multiply(params double[] args)
        {
            double total = args[0];
            for (int x = 1; x < args.Length; x++)
                total *= args[x];

            return total;
        }
        private static double divide(params double[] args)
        {
            double total = args[0];
            for (int x = 1; x < args.Length; x++)
                total /= args[x];

            return total;
        }
        private static double modulus(params double[] args)
        {
            double total = args[0];
            for (int x = 1; x < args.Length; x++)
                total %= args[x];

            return total;
        }
    }
}
