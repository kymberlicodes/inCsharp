using System;
using System.Collections.Generic;

namespace MyFirstSolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Example 1
            /* Console.WriteLine("Hello World!");
            Console.ReadKey(); */

            // Example 2
            /* int var1 = 1;
            int var2 = 2;
            Console.WriteLine(var1 + var2);

            string var3 = "3";
            string var4 = "4";
            Console.WriteLine(var3 + var4); */

            // Example 3
            /* Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}.", name);
            Console.WriteLine("It's nice to meet you, " + name + ".");

            Console.Write("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int nextYearAge = age + 1;
            Console.WriteLine("You're going to be " + nextYearAge + " next year."); */

            // Example 4
            /* Three ways to write variables into strings:
            var myvariable = "Any";
            Console.WriteLine("MyVariable = " + myvariable);
            Console.WriteLine("MyVariable = {0}", myvariable);
            Console.WriteLine($"MyVariable = {myvariable}"); */

            /* int[] firstArray = { 12, 53, 37 };
            Console.WriteLine("firstarray[0] = " + firstArray[0]);
            string[] secondArray = new string[] { "apple", "banana" };
            Console.WriteLine("secondArray[1] = " + firstArray[1]);

            ****** Write lists like this: ****** 
            List<string> myList = new List<string>
            {
                "Johnny",
                "Daniel-San"
            };

            ****** Or like this: ******
            List<string> myList = new List<string>();
            myList.Add("Johnny");
            myList.Add("Daniel-San");
            
            Console.WriteLine($"{myList[0]}, sweep the leg!"); */

            // For & Foreach Loops

            /* for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            foreach (string myString in myList)
            {
                Console.Write(myString + " ");
            } */

            // If/Else Statements

            /* Console.Write("Hey! What's your favorite planet? ");
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
            } */

            // Exception Handling

            /*try
            {
                Console.WriteLine("Starting the app.");
                throw new ApplicationException("Oh no! An error occured!");
                Console.WriteLine("This code will be unreachable.");
            }
            catch (Exception ex) {
                Console.WriteLine("Error caught: " + ex.ToString());
            }
            finally 
            {
                Console.WriteLine("This will happen either way.");
            }*/

            // Homework: Create a Mad-Libs Program
            // Homework: Write a pick a number program. Say if the guess is correct, too high, or too low
            // Homework: Redo number program using a switch statement.

            // Homework: Fizz Buzz. Write a program that rints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz". % to determine numbers that are multiples.
            for (int i = 1; i <= 100; i++) {
                if ((i % 3 == 0) && (i % 5 == 0)) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }

            //END
        }
    }
}
