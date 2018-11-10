using System;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exception Handling
            try
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
            }
        }
    }
}
