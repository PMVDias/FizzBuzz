using System;

namespace Example
{
    class Program
    {
        private const string fizz = "fizz";
        private const string buzz = "buzz";
        private const string lucky = "lucky";

        static void Main(string[] args)
        {
            int numberOfFizz = 0;
            int numberOfBuzz = 0;
            int numberOfFizzBuzz = 0;
            int numberOfLucky = 0;
            int numberOfInteger = 0;

            for (int i = 1; i < 21; i++)
            {
                string output = FizzBuzz.GetFizzBuzzOutput(i);

                if (output == fizz)
                    numberOfFizz++;
                else if (output == buzz)
                    numberOfBuzz++;
                else if (output == fizz + buzz)
                    numberOfFizzBuzz++;
                else if (output == lucky)
                    numberOfLucky++;
                else
                    numberOfInteger++;

                Console.WriteLine(output);
            }
            Console.WriteLine();
            Console.WriteLine("fizz: {0} buzz: {1} fizzbuzz: {2} lucky: {3} intiger: {4}", numberOfFizz, numberOfBuzz, numberOfFizzBuzz, numberOfLucky, numberOfInteger);

            Console.ReadLine();
        }
    }
}
