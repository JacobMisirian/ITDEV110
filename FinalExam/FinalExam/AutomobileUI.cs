using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class AutomobileUI
    {
        public void MainMethod()
        {
            Console.WriteLine("First Automobile: ");
            Automobile firstAutomobile = createAutomobileFromUser();
            Console.Clear();

            Console.WriteLine("\nSecond Auromobile: ");
            Automobile secondAutomobile = createAutomobileFromUser();
            Console.Clear();

            displayInfo("FirstAutomobile:", firstAutomobile);
            displayInfo("SecondAutomobile:", secondAutomobile);
        }

        private string promptForString(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private int promptForInteger(string prompt = "")
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Enter a valid integer!");
                return promptForInteger(prompt);
            }
        }

        private void displayInfo(string automobileName, Automobile automobile)
        {
            Console.WriteLine(automobileName);
            Console.WriteLine("[Make]: " + automobile.Make);
            Console.WriteLine("[Model]: " + automobile.Model);
            Console.WriteLine("[Year]: " + automobile.Year);
            Console.WriteLine("[Owner]: " + automobile.Owner);
            Console.WriteLine("[Color]: " + automobile.Year);
            Console.WriteLine("[Vin Number]: " + automobile.VinNumber);
            Console.WriteLine();
        }

        private Automobile createAutomobileFromUser()
        {
            Automobile automobile = new Automobile(promptForString("Vin Number: "), promptForString("Model: "), promptForString("Make: "), promptForInteger("Year: "));
            automobile.Color = promptForString("Color: ");
            automobile.Owner = promptForString("Owner: ");

            return automobile;
        }
    }
}
