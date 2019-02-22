using System;

namespace Example
{
    public class FizzBuzz
    {
        public static string GetFizzBuzzOutput(int input)
        {
            if (input < 1)
                throw new ArgumentException("Input not valid");
            if (input % 10 == 3)
                return "lucky";
            if (input % 15 == 0)
                return "fizzbuzz";
            if (input % 3 == 0)
                return "fizz";
            if (input % 5 == 0)
                return "buzz";
            return input.ToString();
        }
    }
}
