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

        private static bool IsValidJSONNumber(string console)
        {
            string number = NumericString(console);
            return HasNumber(console, number);
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
            throw new NotImplementedException();
        }
    }
}
