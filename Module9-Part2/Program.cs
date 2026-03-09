namespace Module9_Part2
{
    // STEP 1: Include the System library

    using System;

    // STEP 2: Create a class for the program
    class Program
    {
        // STEP 3: Create the entry point method for the program
        static void Main()
        {
            // STEP 10 (final version of Alert method usage)
           string alertMessage =  Alert(3, "We are all out of coffee", true);
            Console.WriteLine(alertMessage);


        }


        // STEP 4: Create the Alert method with three parameters
        // a) level (int), b) message (string), c) sound (bool)
        public static string Alert(int level, string message, bool sound)
        {

            // STEP 5: Play a beep sound if 'sound' is true
            if (sound)
            {
                Console.Beep(200, 1000);
            }


            // STEP 6: Decide how serious the alert is and change console color
            string howserious;
            switch(level)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Green;
                    howserious = "Not really anything to freak about";
                    break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    howserious = "You should be worried";
                    break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;
                    howserious = "It is time to freak out!";
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    howserious = "Alert level is not set or invlaid";
                    break;
            }
            Console.Clear();


            // STEP 7: Assemble the final alert message
            string result = $" Alert level{level}. {message}. {howserious}."    ;


            // STEP 8: Return the message to Main
            return result;
        }

    }
}
﻿

