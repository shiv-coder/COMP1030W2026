using System;
using System.Collections.Generic;

namespace Lesson11_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 1: Declare a new variable and intialize it as a new List collection of type string
            var coffees = new List<string> { "Americano","Mocaccino","Latte"};

            // STEP 2: Add the names of three different types of coffees in between the { } above.

            // STEP 3: Create a foreach loop to iterate through the above list, with each coffee in the list of coffees
            foreach (var coffee in coffees)
            {

                // STEP 4: Write each coffee on a line in the console
                Console.WriteLine($"Coffee Type: {coffee}");

            }

            // STEP 5: Modify the list by adding some new coffees (with Add), and removing one (with Remove)

            coffees.Add("Espresso");
            coffees.Add("Cappuccino");
            coffees.Remove("Moccacino");
            foreach (var coffee in coffees)
            {

                // STEP 4: Write each coffee on a line in the console
                Console.WriteLine($"Coffee Type: {coffee}");

            }


            // STEP 6a: The List<T> collection allows the reference of elements by index - output your favourite coffee type
            Console.WriteLine($"My favourite Coffee is {coffees[1]}");

            // STEP 6b: Output the 2 new coffee elements to the console as well
            Console.WriteLine($"My favourite Coffee is {coffees[2]} and {coffees[3]}");

            // STEP 7: Search a list - create a variable to contain the index of an element to be found in the list (and pick a coffee to look for with IndexOf())
            var index = coffees.IndexOf("Cappuccino");
            // STEP 8a: Create an if/else structure to capture whether index is -1 or not
            if (index == -1)
            {

                // STEP 8b: Output a message indicating that the list element was not found
                Console.WriteLine($"That the list item is not found, so IndexOf returns {index}");

            }
            else
            {

                // STEP 8c: Output a message indicating the index of the found list elementConsole.WriteLine();

                Console.WriteLine($"The list item {coffees[index]} is located at index {index}");
            }

            // STEP 9: Sort a list - use the Sort() method to re-arrange the list elements in alphabetical order
            coffees.Sort();

            // STEP 10: Use a foreach loop again to output the newly sorted elements of the list collection
            foreach (var coffee in coffees)
            {

                
                Console.WriteLine($"Coffee Type: {coffee}");

            }

            // List<T> can be of other types, too...integers, arrays, etc.

            // This lesson based on the excellent tutorial at https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections
        }
    }
}
