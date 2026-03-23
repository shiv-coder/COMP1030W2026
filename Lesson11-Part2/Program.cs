namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {/*LESSON 10 - Classes and Objects
 
This week we are going to create an application to allow a user to open a bank account, make deposits and withdrawals, and check the balance. The bank account created by this program must support the following features:
    1. The account must have a unique 10-digit identifying number.
    2. It must feature a string that stores the name of the account owner.
    3. It must be able to retrieve the account balance.
    4. There must be a way to deposit an amount to the account.
    5. There must also be a way to withdraw an amount from the account.
    6. When the account is opened, the initial balance must be a positive value.
    7. Any withdrawals from the account cannot result in a balance below zero.
Consider the above list: the first two elements are sort of like properties of the bank account; the following three elements are things that the bank account should be able to do; and the last two elements are rules that the account must follow in order to work properly.*/

            // STEP 1: Add a dependency for Classes


            // STEP 2a: We will add a new class in a separate file - go to Project > Add Class... in Visual Studio and create a new class called BankAccount.cs

            // STEP 2b: Copy the code for BankAccount.cs from Blackboard and paste it into the document - then proceed to STEP 3 in that file


            // STEP 7a: Create a new instance of the object BankAccount - declare and initialize the variable account, with a new BankAccount using your name and the initial balance as the two arguments

            // STEP 7b: Output a sentence to the console describing the new account, then go back to BankAccount.css for STEP 8 to deal with the fact that we do not yet have a bank account number


            // STEP 10a: We need to offer the ability for the account holder to make withdrawals and deposits, so let's add another new class in a separate file - go to Project > Add Class... in Visual Studio and create a new class called Transaction.cs

            // STEP 10b: Copy the code for Transaction.cs from Blackboard and paste it into the document - then proceed to STEP 11 in that file


            // STEP 20a: Attempt a withdrawal, then output the new account balance to the console

            // STEP 20b: Attempt a deposit, then output the new account balance to the console

            // STEP 21: Test for errors by checking to see that the initial balance is positive when opening an account - uncomment the below block of code
            /*
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
            */

            // STEP 22: Test for errors by checking to see whether the bank account will allow the user to withdraw more than the account balance - uncomment the below block of code
            /*
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            */

            // STEP 23: The next step is to add a method to the BankAccount class that will output a log of all transactions - go to BankAccount.cs for STEP 24

            // STEP 25: Attempt to generate a list of all transactions for the account with the new method we just added

            // This lesson is based on the excellent tutorial at https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes // Watch Scott and Kendra build this application at https://learn.microsoft.com/en-us/shows/csharp-101/ - Episode 16
        }
    }
}
