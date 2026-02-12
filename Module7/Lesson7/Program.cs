using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WEEK 7 - ARRAYS

            /* This week we are going to build an application for an ice cream store. The owner would like to be able to do the following
            * Enter sales for each of the 5 ice cream stands for each day of the week
            * View the sales figures for all 5 stands
            * View the highest and lowest daily sales for the week
            * Obtain the average (mean) daily sales for the week
            * See the total sales for the week for the company*/

            // STEP 1: Create an array that can hold all the sales totals for all 5 stands

            int[] sales = new int[5];

            // STEP 2a: Try adding some elements to the array
            sales[0] = 150;
            sales[1] = 200;
            sales[2] = 250;
            sales[3] = 175;
            sales[4] = 300;

            // STEP 2b: Output a specific element of the array, using an index
            Console.WriteLine($"Weekly sales for icecream stand 5 were: ${sales[4]}.");

            // STEP 2c: Try to output an element beyond the index limit of the array
            /*Console.WriteLine($"Weekly sales for icecream stand 5 were: ${sales[5]}.");
             * 
             * 
             */

            // STEP 3a: Create a FOR() loop to allow a user to update each element of the array
            for (int i = 0; i < 5; i++)
            {
                // STEP 3b: Create a temporary variable to capture user input
                int standSales;
                // STEP 3c: Output some instructions for the user (remember that stand 1 is really index 0 in the array)
                Console.WriteLine($"Enter this week's sales for stand {i + 1}:");
                // STEP 3d: Build a WHILE() loop to capture user input and try to parse it to an integer (thanks to yasserpulido - https://stackoverflow.com/questions/13106493/how-do-i-only-allow-number-input-into-my-c-sharp-console-application)
                while(!int.TryParse(Console.ReadLine(), out standSales)) 
                {
                    Console.WriteLine($"Invalid Input. Please enter a number for this week's sale for stand {i + 1}");
                }
                // STEP 3e: We finally got a valid integer, so store the user's input in the array with the correct index 
                sales[i] = standSales;

            }
            // STEP 4: Wrap the rest of the program in a WHILE() loop, repeatedly prompting the user to do something interesting with the newly-created array
            while (true)
            {

                // STEP 5a: Display a menu for the user with a number of choices
                Console.WriteLine("Program Menu:\n1 - View all sales for the week\n2 - View highest sales for the week\n3 - View lowest sales for the week\n4 - View total sales for the week\n5 - View average sales for the week");

                // STEP 5b: Create an integer variable to contain the user's selection
                int optionChoice;
                // STEP 5c: Build a WHILE() loop to attempt to parse the input to an integer 
                while (!int.TryParse(Console.ReadLine(), out optionChoice))
                {
                    Console.WriteLine($"Invalid Input. Please enter your choice from the above menu --numbers 1-5");
                }
                // STEP 6: Build and IF/ELSE IF/ELSE conditional to respond to user input
                if (optionChoice == 1)
                {

                    // ALL SALES FOR THE WEEK (CHOICE 1)
                    // STEP 7a: Clear the screen
                    Console.Clear();
                    Console.WriteLine("------Ice Cream Stands--------");

                    // STEP 7b: Output all sales for the week using a for() loop
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Stand{i + 1}: ${sales[i]}");


                    }
                    Console.WriteLine("\n(End of Sales Report)");
                }
                else if (optionChoice == 2)
                {

                    // HIGHEST SALES OF THE WEEK (CHOICE 2)
                    // STEP 8a: Clear the screen
                    Console.Clear();

                    // STEP 8b: Create a variable to contain the highest sales figure (assume the first element of the array is the highest to start with)
                    int highestSales = sales[0];
                    // STEP 8c: Make a foreach() loop to iterate through each item in the array
                    //Syntax of foreach loop
                    //foreach(datatype variable in collection(arrays/List){  }

                    foreach (int sale in sales)
                    {
                        // STEP 8d: Construct an IF statement to compare each element in the array to the highest
                        if (sale > highestSales)
                        {
                            highestSales = sale;
                        }

                    }

                    // STEP 8e: Output the highest sales figure for the week
                    Console.WriteLine($"The highest sales for this week was: ${highestSales}");
                }
                else if (optionChoice == 3)
                {

                    // LOWEST SALES OF THE WEEK (CHOICE 3)
                    // STEP 9a: Clear the screen
                    Console.Clear();

                    // STEP 9b: Create a variable to contain the lowest sales figure (assume the first element of the array is the lowest to start with)
                    int lowestSales = sales[0];
                    // STEP 9c: Make a foreach() loop to iterate through each item in the array
                    foreach (int sale in sales)
                    {
                        // STEP 9d: Construct an IF statement to compare each element in the array to the highest
                        if (sale < lowestSales)
                        {
                            lowestSales = sale;
                        }

                    }

                    // STEP 9e: Output the lowest sales figure for the week
                    Console.WriteLine($"The lowest sales for this week was: ${lowestSales}");
                }
                else if ((optionChoice == 4))
                {

                    // TOTAL SALES FOR THE WEEK (CHOICE 4)
                    // STEP 10a: Clear the screen
                    Console.Clear();
                    // STEP 10b: Declare a variable to track the total sales
                    int totalSales = 0;
                    // STEP 10c: Determine the length of the sales[] array using the .Length property
                    //int numberStands = sales.Length;
                    // STEP 10d: Assemble a for() loop, incorporating the .Length property in order to add each element of the array to the above variable
                    for (int i = 0; i < sales.Length; i++)
                    {

                        totalSales += sales[i]; ;
                    }
                    // STEP 10e: Output the total sales for the week
                    Console.WriteLine($"Total sales for the wek was : ${totalSales}");

                }
                else if (optionChoice == 5)
                {


                    // AVERAGE SALES OF THE WEEK (CHOICE 5)    
                    // STEP 11a: Clear the screen
                    Console.Clear();
                    // STEP 11b: Declare a variable to track the total sales
                    int totalSales = 0;
                    // STEP 11c: Assemble a FOREACH loop to add each element of the array to the above variable
                    foreach (int sale in sales)
                    {
                        totalSales += sale;
                    }
                    // STEP 11d: Calculate the average sale by using the length property of the array (note we need to cast the total variable value as a float)
                    double averageSales = (double)totalSales / sales.Length;
                    // STEP 11e: Output the average sales for the week
                    Console.WriteLine($"The average sales for the week was: ${averageSales}");

                }
                else
                {
                    // STEP 12: The user did not type in a valid choice - provide a friendly error message
                    Console.WriteLine("You did not enter a valid choice. please try again- pick from the above list");
                }
            }

            
        }
    }
}
   