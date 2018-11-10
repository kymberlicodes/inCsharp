using System;

namespace ExampleThree
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}.", name);
            Console.WriteLine("It's nice to meet you, " + name + ".");

            Console.Write("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int nextYearAge = age + 1;
            Console.WriteLine("You're going to be " + nextYearAge + " next year.");
        }
    }
}
