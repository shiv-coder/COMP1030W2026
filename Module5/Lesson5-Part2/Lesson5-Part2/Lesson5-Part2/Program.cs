using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LESSON 5 - PART 2

            /* STEP 1a: The while loop
                  while(condition-true/false)
                  {
                 Type Code to execute repeatedly
             *      }
             */
            while (false)
            {
                Console.WriteLine("While loops are awsome");
            }
            // STEP 1b: Set the above condition to false


            // STEP 2a: The do while loop
            do
            {
                Console.WriteLine("Do-while loops are awsome");
            } while (false);

            // STEP 2b: Set the above condition to false


            // STEP 3a: Conducting input validation using a do/while loop - declare an integer to represent the user's age

            int age;
            // STEP 3b: Build out the do/while structure
            do
            {

                // STEP 4a: Ask the user their age and capture the input
                Console.WriteLine("What is your age");
                string ageString = Console.ReadLine();

                // STEP 4b: Try to convert the input to an integer - declare a variable to contain the number

                int ageNum;
                // STEP 4c: Create a boolean variable that attempts to parse the user's age into an integer (https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-6.0)
                bool isParsable = Int32.TryParse(ageString, out ageNum);
                // STEP 4d: If the ageString cannot be converted to an integer, or it is not within the correct age range, then output an error message
                if (isParsable == false || (ageNum < 1 || ageNum > 100))
                {
                    age = -1;
                    Console.WriteLine("You must enter anumber between 1 and 100");
                }
                // STEP 4e: Otherwise, the user input can be converted to an integer and it is in the correct range
                else
                {
                    age = ageNum;
                }
            }  while(age< 1 || age> 100);

            // STEP 3c: Continue the do/while loop while age is less than 1 or greater than 100


            // STEP 5: The above while statement evaluated to false, so the loop was ended
            Console.WriteLine($"{age} is a great age to be!");

            // STEP 6a: Add a breakpoint to the above program at the while() statement

            // STEP 6b: Compile and run the program and observe the available diagnostic features
        }
    }
}
