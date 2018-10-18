using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class RomanNumerals
    {
        //Takes an integer and return a roman numeral for that number
        static void Main(string[] args)
        {         
            Console.WriteLine("\n\tRomanNumerals.Main()\n\t...continue?...");
            Console.ReadKey();

            Console.WriteLine(romanNumeral(2));
            Console.ReadLine();

        }
        public static string romanNumeral (int value)
        {
                string result = "";
                while (value > 0)
                {
                    result += 'I';
                    value--;
                }
                return result;
        }

        


    }
}
