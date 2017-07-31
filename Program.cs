using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (float i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            Console.WriteLine("*************************************************");
            for (float i = 1; i < 101; i++)
            {

                if (i / 15 == Math.Floor(i / 15))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i / 3 == Math.Floor(i / 3))
                {
                    Console.WriteLine("Fizz");
                }
                else if (i / 5 == Math.Floor(i / 5))
                {
                    Console.WriteLine("Buzz");
                }
            }
            Console.WriteLine("*************************************************");
            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                float temp = (rand.Next(1, 100));
                if (temp / 15 == Math.Floor(temp / 15))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (temp / 3 == Math.Floor(temp / 3))
                {
                    Console.WriteLine("Fizz");
                }
                else if (temp / 5 == Math.Floor(temp / 5))
                {
                    Console.WriteLine("Buzz");
                }

            }
            Console.WriteLine("Hello World!");
        }
    }
}
