using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxCount = 100;
            for (int i = 0; i < MaxCount; i++)
            {
                var displayOutput = "";
                var outputInteger = true;
                if (i % 3 == 0)
                {
                    displayOutput = displayOutput + "Fizz";
                    outputInteger = false;
                }
                if (i % 5 == 0)
                {
                    displayOutput = displayOutput + "Buzz";
                    outputInteger = false;
                }

                if (outputInteger)
                {
                    displayOutput = $"{i}";
                }
                Console.Write("\n" + displayOutput);
            }
        }
    }
}