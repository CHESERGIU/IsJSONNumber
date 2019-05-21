using System;

namespace IsNumberJSON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (IsValidJSONNumber(Console.ReadLine()) == true)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadLine();
        }

        public static bool IsValidJSONNumber(string console)
        {            
            return HasNumber(console) 
                && !HasLeadingZero(console)
                && !EndWith(console); ;
        }

        private static bool HasNumber(string input)
        {
            int countExponent = 0;            
            int countPlus = 0;
            int countMinus = 0;
            int countPoint = 0;
            foreach (char c in input) {
                if (Char.IsDigit(c) || "eE+-.".Contains(c))
                {                    
                    if (c == 'E' || c == 'e') countExponent++; if (countExponent > 1) return false;                     
                    if (c == '+') countPlus++; if (countPlus > 1) return false;
                    if (input[0] != '-' && c == '-') countMinus++; if (countMinus > 1) return false;
                    if (c == '.') countPoint++; if (countPoint > 1) return false;
                    if (input[0] == 'E' || input[0] == 'e' || input[0] == '+') return false;
                    if (countExponent == 0 && (countPlus == 1 || countMinus == 1) ) return false;
                    if (countPoint == 0 && (countExponent == 1 || countPlus == 1 || countMinus == 1)) return false;
                }
            }
            return true;
        }
        public static bool HasLeadingZero(string input)
        {
            return input[0] == '0' && input[1] != '.';
        }

        public static bool EndWith(string input)
        {
            return input.EndsWith(".") || input.EndsWith('E');
        }
    }
}
