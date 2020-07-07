using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxCount = 115;
            List<string> output = new List<string>();
            for (int i = 1; i <= MaxCount; i++)
            {
                output.Clear();
                if (i % 3 == 0)
                {
                    output.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    output.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    output.Add("Bang");
                }
                if (i % 11 == 0)
                {
                    output.Clear();
                    output.Add("Bong");
                }
                if (i % 13 == 0)
                {
                    output.Insert(output.IndexOf("Fizz") == -1 ? 0 : 1, "Fezz");
                }
                
                if (i % 17 == 0)
                {
                    output.Reverse();
                }
                
                if (!output.Any())
                {
                    output.Add($"{i}");
                }

                foreach (var displayOutput in output)
                {
                    Console.Write(displayOutput);
                }

                Console.Write("\n");
            }
        }
    }
}