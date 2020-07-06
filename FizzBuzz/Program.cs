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
                var flag = true;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    flag = false;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    flag = false;
                }
                if (flag)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }
    }
}