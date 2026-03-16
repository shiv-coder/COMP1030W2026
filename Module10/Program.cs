// STEP 1: Add a 'using' directive for the namespace 'Wheel'
using Classes;
namespace Module10
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Week 10 - Classes, Objects, Members, Properties, Constructors, and Methods
 
            This week we are going to revisit how to build a class, then create an instance of an object based on that class, and invoke a simple method
 
            The program that we build will enable a person to create a wheel of a specific diameter, then roll it a number of times and determine how far the wheel has travelled. The program must provide for the following:
                1. It must enable a wheel object to be created, which will store its diameter (measured in cm).
                2. A wheel object can be instructed to rotate a specified number of times, and it will report the amount of distance travelled.
                3. An instance of the wheel object must measure between 10 and 100 cm.
            */


            // STEP 2: We will add a new class in a separate file - go to Project > Add Class... in Visual Studio and create a new class called Wheel.cs

            // STEP 8: Create a new wheel object, using the CONSTRUCTOR you just built inside Wheel.cs, passing in a diameter as the only argument
            var wheel1 = new Wheel(15);

            // STEP 9: We now have an object of class Wheel called "wheel1" with a diameter of 15 cm, but it does not do anything - let's go back to Wheel.cs


            // STEP 11: Let's now call the Roll() method of the wheel1 object, rolling it 3 times around, and capture the returned value as a number (type double)

            // STEP 12: Now we can output a sentence that describes wheel1, and how far it actually rolled

            // STEP 13: Create a second wheel object, with a different diameter

            // STEP 14: Call the Roll() method of the wheel2 object (all instances of Wheel have this functionality), and roll it 7 times around (or whatever), capturing the returned value as the distance once again

            // STEP 15: Write another sentence describing what is going on with wheel2

            // STEP 16: Instantiate a third Wheel object, then invoke the Roll() method, and output the result to the console.

            // STEP 17: What if a user tries to create a wheel with a diameter that is too big or too small? Head over to Wheel.cs to see how to solve this problem

            // STEP 19: We will try to create another Wheel object with an invalid diameter - declare a new variable as type Wheel

            // STEP 20a: Build the try/catch structure - start with try { }

            // STEP 20b: Attempt to create a new Wheel object with a diameter that is too big or too small using the variable name set in STEP 19

            // STEP 20c: Add the catch { } part of the structure, passing in the ArgumentOutOfRangeException (that we set up in Wheel.cs) as a handler for the event - include 'evt' for the exception event itself

            // STEP 20d: Output the exception event (evt) as a string to the console, then exit out of the try-catch with return


        


        }
    }
}
