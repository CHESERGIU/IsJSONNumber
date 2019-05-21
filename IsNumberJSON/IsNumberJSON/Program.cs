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
            return numericString = IsValid(input, numericString);
        }

        private static string IsValid(string input, string numericString)
        {
            foreach (char c in input)
                numericString = EvaluateString(numericString, c);
            return numericString;
        }

        private static string EvaluateString(string input, char c)
        {
            if ((c >= '0' && c <= '9') || c == 'E' || c == '-' || c == '+' || c == '.' || c == 'e')
                input = String.Concat(input, c);
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
