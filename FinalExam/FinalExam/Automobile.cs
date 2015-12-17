using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Automobile
    {
        public string VinNumber { get; private set; }
        public string Model { get; private set; }
        public string Make { get; private set; }
        public int Year { get; private set; }
        public string Owner { get; set; }
        public string Color { get; set; }

        public Automobile(string vinNumber, string model, string make, int year)
        {
            this.VinNumber = vinNumber;
            this.Model = model;
            this.Make = make;
            this.Year = year;
        }
    }
}
