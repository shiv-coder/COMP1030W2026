using System;
using System.Collections.Generic;
using System.Text;

// STEP 3: Define the namespace (Classes)
namespace Classes
{
    
    // STEP 4: Create a class (a blueprint or template for an object) - called Wheel
    public class Wheel
    {
       
        // STEP 5: A wheel object really only needs to store one PROPERTY - its diameter
        public double Diameter { get; }

        // STEP 6a: The CONSTRUCTOR for the wheel object only accepts one argument - the diameter - which it uses to set the above PROPERTY
        public Wheel(double diameter)
        {

            // STEP 6b: Set the Diameter property to the value of the parameter above
            this.Diameter = diameter;

        }

        // STEP 7: We have now completed the class PROPERTY and it now has a CONSTRUCTOR, so now we can create a new Wheel object - go back to Program.cs

        // STEP 10a: Create a method called Roll with a parameter that allows someone to indicate how many times a wheel object has rotated

        // This method represents something that a wheel can DO - it can roll - and in this case it will report back (or return) how far it rolled

        // STEP 10b: The wheel will travel the diameter multiplied by Ï€, times the number of times the wheel rotated around

        // STEP 10c: Send the distance the wheel travelled back to where this method was called (invoked) in Program.cs

        // STEP 18a: If the user tries to create a new Wheel object that is too big or too small, we need to generate a useful error - create an if() statement that checks the diameter

        // STEP 18b: The diameter is out of the allowable range for the argument, so we will throw a new ArgumentOutOfRangeException() with a helpful error message

        // STEP 18c: Move this entire if() structure inside the CONSTRUCTOR for the class above, then go back to Program.cs for the next step
    }
}
