using System;
using System.Collections.Generic;

namespace ExampleFour
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Three ways to write variables into strings:
            var myvariable = "Any";
            Console.WriteLine("MyVariable = " + myvariable);
            Console.WriteLine("MyVariable = {0}", myvariable);
            Console.WriteLine($"MyVariable = {myvariable}");

            int[] firstArray = { 12, 53, 37 };
            Console.WriteLine("firstarray[0] = " + firstArray[0]);
            string[] secondArray = new string[] { "apple", "banana" };
            Console.WriteLine("secondArray[1] = " + firstArray[1]);

            // Write lists like this:
            List<string> myList1 = new List<string>
            {
                "Johnny",
                "Daniel-San"
            };

            // Or like this:
            List<string> myList2 = new List<string>();
            myList2.Add("Johnny");
            myList2.Add("Daniel-San");

            Console.WriteLine($"{myList1[0]}, sweep the leg!");
            Console.WriteLine($"{myList2[0]}, sweep the leg!");
        }
    }
}
