/*
    Author: Derrick Burns
    Date: 9/18/2019
    Comments: This application code demonstrates the use of methods.
 */

using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first and last name: ");
            
            // This variable will gather data from user input
            string input = Console.ReadLine();

            Console.WriteLine("\n");

            // Call Print_Name method
            Print_Name(input);
        } // End of main
        
        // Method that displays user input
        private static void Print_Name(string input)
        {
            Console.WriteLine("Hello " + input + "!");
        } // End of Print_Name
    } // End of class
} // End of namespace
