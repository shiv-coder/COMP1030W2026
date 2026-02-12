using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LESSON 5 - PART 3

            Console.WriteLine("Times Table Tutor");
            // STEP 1: Declare and initialize a count variable
            int count = 1;

            // STEP 2: Declare and initialize the number that the Times Table Tutor will focus on
            int timesValue = 2;

            // STEP 3: Start with a while() loop that stops the loop at 13 (Times Tables traditionally go from 1 to 12)
            while (count < 13)
            {

                // STEP 4: Calculate the result of the current factor (count) times the number we are focused on (timesValue)
                int result = count * timesValue;
                //result = 1 * 2;
                //result = 2 * 2;
                //result = 12 *2;


                // STEP 5a: Build out the message to the user
                string message = count.ToString() + " times " + timesValue.ToString() + " is equal to " + result.ToString();

                // STEP 5b: Output the resulting message to the user
                Console.WriteLine(message);


                // STEP 6: Increment the counter variable

                count++; //count = count + 1;
                // STEP 7: How would you update the above program to output the times table for the number 7?
            }

            // STEP 8: What would happen if the increment statement (STEP 6) was changed to a decrement (-)?

            Console.WriteLine("\n\n");

            /* Next, let's recreate the above program using a FOR loop (to make it a bit simpler), which features the following structure:
            * for ( setup ; test ; update ) { statement }
            * - the setup is done once when the loop is started
            * - the test is performed before the execution of the loop, and if it evaluates to true, then the loop statements are performed
            * - the update is completed after each execution of the loop */

            // STEP 9: Build out the FOR loop conditional structure (use i instead of count this time...this is common in programming and it refers to iteration which is the repetition of a procedure of some kind)
            //for(initilization, condition, Increment)
            
            for (int i = 1; i < 13; i++)
            {
                // Generate current number in the times table
                int result = i * timesValue;
                // STEP 10b: Check for unlucky number 12, and break if needed - this will exit the loop
                if (result == 12)
                //Console.WriteLine("We cannot go on because of the unlucky number 12.");
                {
                    Console.WriteLine("We must skip the unlucky number 12");
                    // STEP 11b: Comment out the above 'break' and add 'continue' to skip the statements below and proceed with the next number in the loop
                    continue;
                    // STEP 11c: Update the above comment so that it makes more sense

                }
                // Build the message to the user and output to console
                string message = i.ToString() + " times " + timesValue.ToString() + " is equal to " + result.ToString();
                Console.WriteLine(message);

                // It is not neccessary to increment the counter, as it is done at the top of the loop


                // STEP 10a: We can break out of a loop if we need to. Let's say the user feels that the number 12 is unlucky, and if the times table includes this product, they must stop
            }

            // STEP 11a: Alternatively, if we'd like to just skip the unlucky number 12, then we can continue from a certain point, jumping to the top of the next loop iteration
        }
    }
}
