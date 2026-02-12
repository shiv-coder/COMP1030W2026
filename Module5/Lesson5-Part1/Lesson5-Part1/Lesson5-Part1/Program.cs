using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LESSON 5 - PART 1

            // STEP 1: Declare and initialize variables
            int cheeseAndTomatoCount = 0;
            int pepperoniCount = 0;
            int vegetarianCount = 0;

            // STEP 8: Wrap the entire program in a while loop, repeatedly asking for pizza selections
            //while(true)-infinte loop(runs forever)
            // STEP 2a: Offer the user some instructions
            while (true)
            { //keep showing menu forever

                Console.Clear();

                string toppingOptions = $"PIZZA SELECTION\n\nPick one of the following pizzas:\n[A] Cheese and Tomato\n[B] Pepperoni\n[C] Vegetarian\n[T] View order totals\nPress the letter indicating your selection";
                Console.WriteLine(toppingOptions);

                // STEP 2b: Collect their input
                ConsoleKeyInfo toppingChoiceInput = Console.ReadKey();
                // STEP 2c: Grab just the letter they chose from the keypress and convert to string
                string toppingChoice = toppingChoiceInput.Key.ToString();//A-> "A"

                // STEP 3a: Build an IF statement to be sure that they typed one of letters A, B, C, or T
                if (toppingChoice == "A")
                {
                    cheeseAndTomatoCount = cheeseAndTomatoCount + 1;
                }
                else if (toppingChoice == "B")
                {
                    // STEP 4: Use an increment operator
                    pepperoniCount++;  //pepproniCount = pepproniCount + 1;

                }
                else if (toppingChoice == "C")
                {
                    vegetarianCount++;
                }
                else if (toppingChoice == "T")
                {
                    // STEP 5: Output the order totals
                    Console.Clear();
                    Console.WriteLine("ORDER TOTALS");
                    Console.WriteLine($"Cheese and Tomato: {cheeseAndTomatoCount} pizzas");
                    Console.WriteLine($"Pepperoni: {pepperoniCount} pizzas");
                    Console.WriteLine($"Vegetarian: {vegetarianCount} pizzas");

                    // STEP 6a: Offer the user a choice between [R] Reset and [F] Finish order
                    Console.WriteLine("What would you like to do next:\n[R] Reset\n[F] Finish Order");

                    // STEP 6b: Collect their input
                    ConsoleKeyInfo replyInput = Console.ReadKey();
                    // STEP 6c: Grab just the letter they chose from the keypress and convert to string
                    string replyChoice = replyInput.Key.ToString();

                    // STEP 7a: Check to see if the user chose to reset the order
                    if (replyChoice == "R")
                    {
                        // STEP 7b: Clear out the order counts
                        cheeseAndTomatoCount = 0;
                        pepperoniCount = 0;
                        vegetarianCount = 0;

                        // STEP 7c: Clear the screen and output an order reset confirmation
                        Console.Clear();
                        Console.WriteLine("Order Reset");

                    }
                    else if (replyChoice == "F") // STEP 8: They want to finish their order
                    {
                        Console.Clear();
                        Console.WriteLine("ORDER COMPLETE\nThank you for your business. Your order includes the following:");
                        Console.WriteLine($"Cheese and Tomato: {cheeseAndTomatoCount} pizzas");
                        Console.WriteLine($"Pepperoni: {pepperoniCount} pizzas");
                        Console.WriteLine($"Vegetarian: {vegetarianCount} pizzas");
                        Console.WriteLine("Have a great day!");

                        // STEP 9: Break out of the loop
                        break;

                    }
                }
                else // STEP 3b: They typed something else on the keyboard - provide an error message
                {
                    Console.WriteLine($"Sorry - you must enter one of the letters listed above to make your selection.");
                }
            }
        }
    }
}
