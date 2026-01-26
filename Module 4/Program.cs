namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program1.Run();
            // STEP 1: Create a random number between 0 and 24 to represent the hour of the day
            Random rand = new Random();
            int hour = rand.Next(0, 24);
            Console.WriteLine(hour);


            // STEP 2: Introducing the boolean type - declare a boolean variable to see if it is time to wake up
            bool timeToWakeUp = hour > 5;
            // STEP 3a: Build an if/else structure (a conditional statement) that outputs a message indicating whether it is time to wake up or not

            if (timeToWakeUp)
            
                Console.WriteLine($"It is {hour} O' clock and it is time to wake up!");
            
            else
            
                Console.WriteLine($"It is {hour} O' clock. Go back to sleep");



            // STEP 3b: Note that spacing with above lines is optional - it is formatting to make code easier to read

            /* STEP 4: Relational operators (<, >, <=, >=) are used to compare two values: Construct an if/else structure to determine if it is the morning or the afternoon*/

            if (hour <= 11)
                Console.WriteLine("It is the morning");
            else
                Console.WriteLine("It is afternoon");
            // STEP 5: Equality operators (==, !=) can also be used in a conditional statement

            if (hour != 6)
                Console.WriteLine("It is not DinnerTime!");

            // STEP 6: There is sometimes an issue when comparing real numbers (add 0.1 to 0.2 and compare it to 0.3 - this will evaluation to false as the expression evaluates to 0.30000000000000004)

            double calculateSum = 0.1 + 0.2;
            if (calculateSum == 0.3)
                Console.WriteLine("It is true that 0.1 + 0.2 equals 0.3");
            else
                Console.WriteLine($"calculatedSum equals {calculateSum}");

            // STEP 7a: Comparing Strings - get the day of the week
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);

            // STEP 7b: Output the day of the week
            string today = localDate.ToString("dddd");
            Console.WriteLine($"Todays is: " + today);

            // STEP 7c: Create a condition to check to if today is Monday

            if (today != "Monday")
                Console.WriteLine("Whew-=It is not Monday");
            else
                Console.WriteLine("Bummer- it's Monday");

            /* STEP 8a: Comparing strings is a case-sensitive matter
            ﻿* Declare a string variable to capture your name*/
            string yourName;

            // STEP 8b: Capture the name of the user from the console with Console.ReadLine()
            Console.WriteLine("Please type your name below:");
            // STEP 8c: Output what the user typed in
            yourName = Console.ReadLine();
            // STEP 8d: Write a condition to compare a FULL CAPS version of your name to what was typed in
            if (yourName == "SHIVI")
                Console.WriteLine($"Hello, {yourName}, you are amazing");
            // STEP 9: A code block of one or more statements is delimited using if (), and then{ and }

            if (yourName == "shivi")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hello, {yourName}, you are superb");
                bool myVar = true;
                Console.WriteLine(myVar);
            }
            // STEP 10a: Variables have scope - that is they may be only accessible within the code block within which they were created - create a local string variable

            // STEP 10b: Attempt to access the above local variable


            // STEP 11: There are more complicated logical operators (&, &&, |, ||, ^) - let's try the and (&) operator:﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿

            if (hour < 12 ^ hour >= 18)
                Console.WriteLine("It is not the afternoon");
        }
    }
}
