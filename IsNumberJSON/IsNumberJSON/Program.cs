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
            int count_E = 0;
            int count_e = 0;
            int count_plus = 0;
            int count_point = 0;
            string number = string.Empty;
            foreach (char c in input) {
                if ((c >= '0' && c <= '9') || c == 'E' || c == '-' || c == '+' || c == '.' || c == 'e')
                {
                    number = String.Concat(number, c); Console.WriteLine(number);
                    if (c == 'E') count_E++; if (count_E > 1) break; 
                    if (c == 'e') count_e++; if (count_e > 1) break;
                    if (c == '+') count_plus++; if (count_plus > 1) break;
                    if (c == '.') count_point++; if (count_point > 1) break;
                    if (input[0] == 'E' || input[0] == 'e' || input[0] == '+') break;
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
