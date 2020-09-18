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
            Console.Write("Please enter the grade you expect to get in ISM 4300. ");
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
                 * This variable will be used to store the grade
                 * after the input variable is parsed to an integer
                 */
                int grade = int.Parse(input);

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Please enter an integer between 0 and 100... try again");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                if (grade == 90)
                {
                    Console.WriteLine("Your grade is A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your grade is B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your grade is C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your grade is D");
                }
                else if (grade >= 0)
                {
                    Console.WriteLine("Your grade is F");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer between 0 and 100... try again");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch
        } // end of Main
    } // end of class
} // end of namespace
