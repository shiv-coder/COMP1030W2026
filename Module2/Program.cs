using System;
namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Module 2");

            // STEP 1: Perform the time-honoured "Hello World!" by compiling the above code
            Console.WriteLine("Hello World");

            // STEP 2: Create a simple variable setting the data type to string
            string weatherToday = "cloudy";
            // STEP 3: Write the value of the variable to the console using WriteLine
            Console.WriteLine(weatherToday);

            // STEP 4: Compile and run the app

            // STEP 5: Change the value of the variable set in STEP 2
            weatherToday = "rainy";

            // STEP 6: Write the value of the variable to the console using the WriteLine method again
            Console.WriteLine(weatherToday);

            // STEP 7: Modify the above two lines that generate the output to make a phrase ("The weather today is " + weatherToday)

            Console.WriteLine("The weather today is " + weatherToday);
            // STEP 8: Change STEP 7 so that the line of code uses string interpolation instead of concatenation ($"The weather today is {weatherToday}")

            Console.WriteLine($"The weather today is {weatherToday}");
            // STEP 9: Write a new line that builds a phrase using two variables
            string day = "Monday";
            Console.WriteLine($"The weather on {day} is {weatherToday}");
            // STEP 10: You can output the number of letters in a string using the Length property
            Console.WriteLine($"Number of letters in {weatherToday} : {weatherToday.Length}");

            // STEP 11: Create a string variable for a sentence with spaces at the start and end

            string sentence = "    Today is a windy day    ";

            // STEP 12: Output the above string variable to the console with square brackets around it
            Console.WriteLine($"[{sentence}]");
            // STEP 13: There are other methods for string objects, like Trim() - create a new string variable from the trimmed variable above

            string trimmedSentence = sentence.Trim();
            Console.WriteLine(trimmedSentence);
            // STEP 14: Output the above string variable also between square brackets
            Console.WriteLine($"[{trimmedSentence}]");
            // STEP 15: We can also find and replace text in a string - change "windy" to "snowy" in the above variable using the Replace() method
            string updatedSentence = sentence.Replace("windy", "snowy");
            // STEP 16: Output the revised variable to the console
            Console.WriteLine(updatedSentence);

            // STEP 17: Output the above sentence, but in ALL CAPS using the ToUpper string method
            Console.WriteLine(updatedSentence.ToUpper());

            // STEP 18: We can even search for strings - the Contains() method looks for a string and returns 'true' if it is found, and 'false' if it is not - check to see if the new forecast for Wednesday is "snowy"
            bool containsSnowy = updatedSentence.Contains("snowy");
            Console.WriteLine($"Contains 'snowy' ? {containsSnowy}");
            // STEP 19: Update the above to look for "rainy" instead
            bool containsrainy = updatedSentence.Contains("rainy");
            Console.WriteLine($"Contains 'rainy' ? {containsrainy}");
            // Inspired by the Microsoft tutorial at https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world
        }
    }
}
