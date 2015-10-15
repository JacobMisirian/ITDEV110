using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class Positions
    {
        public static string one = @"
 |--------
 | /
 |/
 |
 |
 |
 |";
        public static string two = @"
 |--------
 | /  |
 |/  ( )
 |   
 |   
 |
 |
 ";
       public static string three = @"
 |--------
 | /  |
 |/  ( )
 |    |
 |
 |
 |";
        public static string four = @"
 |--------
 | /  |
 |/  ( )
 |   /|
 |
 |
 |
 ";
        public static string five = @"
 |--------
 | /  |
 |/  ( )
 |   /|\\
 |
 |
 |
 ";
        public static string six = @"
 |--------
 | /  |
 |/  ( )
 |   /|\\
 |   /
 |  
 |
 ";
        public static string seven = @"
 |--------
 | /  |
 |/  (x)
 |   /|\\
 |   / \\
 |
 |
 ";
    }
}
