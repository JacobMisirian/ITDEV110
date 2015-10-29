using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            UserInterface ui = new UserInterface();

            switch (ui.DisplayMenu("Circle", "Rectangle", "Surface of Cylinder"))
            {
                case 0:
                    Console.WriteLine("Area of circle is: " + operations.AreaOfCircle(ui.PromptForDouble("Radius: ")));
                    break;
                case 1:
                    Console.WriteLine("Area of rectangle is: " + operations.AreaOfRectangle(ui.PromptForDouble("Length: "), ui.PromptForDouble("Width: ")));
                    break;
                case 2:
                    Console.WriteLine("Surface area of cylinder is: " + operations.SurfaceAreaOfCylinder(ui.PromptForDouble("Radius: "), ui.PromptForDouble("Height: ")));
                    break;
                default:
                    throw new Exception("Something has gone terribly wrong here.");
            }

            Console.Read();
        }
    }
}
