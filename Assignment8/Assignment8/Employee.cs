using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Employee
    {
        public string ID { get; private set; }
        public int HourlyWage { get; set; }
        public string LastName { get; set; }
        public int HoursWorked { get; private set; }

        public Employee(string ID)
        {
            this.ID = ID;
            this.HoursWorked = 0;
        }

        public void EnterHoursWorked(int hours)
        {
            this.HoursWorked += hours;
        }

        public int CalculateWeeklyPay()
        {
            return HoursWorked * HourlyWage;
        }

        public string DisplayInfo()
        {
            return "ID: " + ID + "\nName: " + LastName + "\nHourly Pay: " + HourlyWage + "\nAmount paid per week: " + CalculateWeeklyPay();
        }
    }
}
