/*
  Author: Catherine Santos
  Date: 09/17/2020
  Comments: This C# Console application code demonstrates the use of
            conditional statements after getting input from users
*/

using System;
using System.Reflection.Metadata;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300? Enter the grade points to see the letter grade");
            /*
             * Use the try catch block to validate user input.
             * If the user provides incorrect input, the catch block 
             * will handle the error and a message will be displayed.
             */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /*
                 * This variable will be used to store sales
                 * after the input variable is parsed to decimal
                 */

            }
        }
    }
}
