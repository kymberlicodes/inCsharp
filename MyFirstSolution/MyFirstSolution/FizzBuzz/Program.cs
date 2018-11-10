using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 
            Homework: Fizz Buzz. Write a program that prints the
            numbers from 1 to 100. But for multiples of three print
            "Fizz" instead of the number and for the multiples of
            five print "Buzz". For numbers which are multiples of
            both three and five print "FizzBuzz". % to determine
            numbers that are multiples.
            */

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}