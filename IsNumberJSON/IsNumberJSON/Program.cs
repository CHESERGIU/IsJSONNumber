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

        private static bool HasNumber(string console, string number)
        {
            throw new NotImplementedException();
        }

        private static string NumericString(string console)
        {
            throw new NotImplementedException();
        }
    }
}
