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
            return !HasNumber(console) 
                && !HasLeadingZero(console)
                && !EndWith(console); ;
        }

        private static bool HasNumber(string input)
        {            
            string number = string.Empty;
            foreach (char c in input) {
                if ((c >= '0' && c <= '9') || c == 'E' || c == '-' || c == '+' || c == '.' || c == 'e')
                {
                    number = String.Concat(input, c);
                }
            }
            return input.Equals(number); 
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
