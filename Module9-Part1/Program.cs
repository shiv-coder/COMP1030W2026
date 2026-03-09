namespace Module9_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 1: Create a simple method called myMethod

            void myMethod()
            {
                // STEP 2: The method outputs a message to the console
                Console.WriteLine("I created a new method succesfully");

            }

            // STEP 3: Call the method from the program
            myMethod();

            // STEP 4: Create another method called myMethod2 that features one parameter (a string called whatEver)
            void myMethod2(string whatever)
            {
                // STEP 5: Write a message to the console featuring the argument that will be passed into the method
                Console.WriteLine($"The method myMethod2 was called with the follwoing argument: {whatever}");
            }

            // STEP 6: Invoke (call) myMethod2 with an argument
            myMethod2("I need Coffee");

            // STEP 7: Create another method (myMethod3) that returns a value - the number of characters in a string
            int myMethod3(string mySentence)
            {
                int numChars = mySentence.Length;
                return numChars;

            }

            // STEP 8a: Prompt the user to enter a sentence
            Console.WriteLine("Type in a short sentence and this program will count the number of characters for you");
             string mySentence = Console.ReadLine();

            // STEP 8b: Invoke the new method, and pass it in the above sentence for counting characters - but assign this to a new string variable to hold the retured value
            int CharsInSentence = myMethod3(mySentence);

            // STEP 9: Output a sentence to the console indicating how many characters are in the above sentence
            Console.WriteLine($"There are {CharsInSentence} characters in the sentence");

            // STEP 10: Great work, now let's move onto Part 2 of this week's lesson
        }
    }
}
