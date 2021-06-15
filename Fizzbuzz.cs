using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);

                if (fizz && buzz)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
