using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FormattedOutput
    {
        private char c { get; set; }

        public FormattedOutput(char letter)
        {
            this.c = letter;
        }

        public void DisplayLetter()
        {
            string s = Convert.ToString(this.c);
            Console.WriteLine(s + "\t" + Convert.ToString((int)this.c, 2) + "\t" + String.Format("{0:X}", ((int)this.c)) + "\t" + Convert.ToString(this.c, 8) + "\t" + ((int)this.c));
        }
    }
}
