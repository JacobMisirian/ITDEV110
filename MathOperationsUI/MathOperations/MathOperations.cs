using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperations
{
    public class MathOperations
    {
        public int FirstOperand { get; set; }
        public int SecondOperand { get; set; }

        public MathOperations()
        {
        }

        public double Addition()
        {
            return FirstOperand + SecondOperand;
        }

        public double Subtraction()
        {
            return FirstOperand - SecondOperand;
        }

        public double Multiplication()
        {
            return FirstOperand * SecondOperand;
        }

        public double Division()
        {
            return FirstOperand / SecondOperand;
        }
    }
}
