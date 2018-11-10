using System;

namespace ControlFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // For & Foreach Loops
            int[] firstArray = { 12, 53, 37 };
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            foreach (int i in firstArray)
            {
                Console.Write(i + " ");
            }

            // If/Else Statements
            Console.Write("Hey! What's your favorite planet? ");
            string planet = Console.ReadLine();
            if (planet == "Earth")
            {
                Console.WriteLine("Hey! I live there.");
            }
            else if (planet == "Pluto")
            {
                Console.WriteLine("What's not a planet any more.");
            }
            else
            {
                Console.WriteLine("Mine's the sun!");
            }
        }
    }
}
