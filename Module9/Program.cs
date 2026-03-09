using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PASS BY VALUE EXAMPLE");
        Console.WriteLine("----------------------");

        int number = 10;

        Console.WriteLine("Before method call: " + number);
        ChangeValue(number);     // Pass by Value
        Console.WriteLine("After method call: " + number);

        Console.WriteLine();

        Console.WriteLine("PASS BY REFERENCE EXAMPLE");
        Console.WriteLine("--------------------------");

        int number2 = 10;

        Console.WriteLine("Before method call: " + number2);
        ChangeReference(ref number2);   // Pass by Reference
        Console.WriteLine("After method call: " + number2);
    }

    // PASS BY VALUE
    // A copy of the variable is sent to the method
    static void ChangeValue(int num)
    {
        num = num + 10;
        Console.WriteLine("Inside method (Value changed to): " + num);
    }

    // PASS BY REFERENCE
    // The actual variable is sent using 'ref'
    static void ChangeReference(ref int num)
    {
        num = num + 10;
        Console.WriteLine("Inside method (Reference changed to): " + num);
    }
}