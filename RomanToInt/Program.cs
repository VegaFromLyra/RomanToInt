using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Conver roman numeral to int
// Rules for roman to regular number conversion can be here
// http://www.factmonster.com/ipka/A0769547.html
namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}: {1}", "MCMXC", RomanToInt("MCMXC"));
            Console.WriteLine("{0}: {1}", "MMVIII", RomanToInt("MMVIII"));
            Console.WriteLine("{0}: {1}", "MDCLXVI", RomanToInt("MDCLXVI"));
        }

        // Assumes input has valid roman characters
        static int RomanToInt(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return -1;
            }

            // make sure the input is upper case
            input = input.ToUpper();

            Dictionary<char, int> table = new Dictionary<char, int>();

            table.Add('I', 1);
            table.Add('V', 5);
            table.Add('X', 10);
            table.Add('L', 50);
            table.Add('C', 100);
            table.Add('D', 500);
            table.Add('M', 1000);

            int prev = table[input[input.Length - 1]];

            int current = 0;

            int result = prev;

            for (int i = input.Length - 2; i >= 0; i--)
            {
                current = table[input[i]];

                if (current < prev)
                {
                    result -= current;
                }
                else
                {
                    result += current;
                }

                prev = current;
            }

            return result;
        }

    }
}
