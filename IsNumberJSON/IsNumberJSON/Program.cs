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
            string number = NumericString(console);
            return HasNumber(console, number) 
                && !HasLeadingZero(console, number)
                && !EndWith(console); ;
        }

        private static bool HasNumber(string input, string number)
        {
            return input.Equals(number);
        }

        private static string NumericString(string input)
        {
            string numericString = string.Empty;
            foreach (char c in input) {
                if ((c >= '0' && c <= '9') || c == 'E' || c == '-' || c == '+' || c == '.' || c == 'e')
                {
                    numericString = String.Concat(input, c);
                }
            }            
            return input;
        }
        public static bool HasLeadingZero(string input, string number)
        {
            return input[0] == '0' && input[1] != '.';
        }

        public static bool EndWith(string input)
        {
            return input.EndsWith(".") || input.EndsWith('E');
        }
    }
}
