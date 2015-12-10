using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class EmployeeUI
    {
        private Employee currentEmployee;
        public EmployeeUI()
        {
        
        }

        public void MakeEmployess()
        {
            List<Employee> employees = new List<Employee>();
            for (int x = 0; x < 2; x++)
            {
                Employee employee = new Employee(randomID());
                employee.LastName = prompt("Enter last name: ");
                employee.EnterHoursWorked(promptForInt("Enter hours worked: "));
                employee.HourlyWage = promptForInt("Enter hourly wage: ");
                employees.Add(employee);
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.DisplayInfo());
            }
        }

        public void FillHoursWorked()
        {
            for (int x = 1; x <= 7; x++)
            {
                Console.WriteLine("Enter pay for " + x + " : ");

            }
        }

        public int promptForInt(string msg)
        {
            Console.Write(msg + ": ");
            string input = Console.ReadLine();
            int res = 0;
            try
            {
                res = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Enter a valid number!");
                return promptForInt(msg);
            }

            return res;
        }

        private string prompt(string msg)
        {
            Console.Write(msg + ": ");
            return Console.ReadLine();
        }

        private string randomID()
        {
            Random rand = new Random();
            string res = "";
            string letters = "abcdefghijklmnopqrstuvwxyz1234567890";
            for (int x = 0; x < 8; x++)
                res += letters[rand.Next(0, letters.Length - 1)].ToString();
            return res;
        }
    }
}
