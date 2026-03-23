using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Classes;
// STEP 3: The namespace declaration offers a way to logically organize code - add the namespace Classes below
namespace Classes
{
    // STEP 4: Build a class called BankAccount - all the code within the following { and } control the state and the behavior of the class
    public class BankAccount
    {

        // STEP 5: There are five members of this class - the first 3 below are properties (which are data elements), and the last two are methods which perform functions required of the bank account

        // CLASS PROPERTIES
        private static int accountNumberSeed = 1234567890;

        // STEP 8: Add a new member declaration (called accountNumberSeed) - this one will be private (only accessible to code inside this class), and it will be static, meaning it is shared by all of the BankAccount objects
        public string Number { get; }
        public string Owner { get; set; }

        private List<Transaction> allTransactions = new List<Transaction>();
        
        public decimal Balance
        {
            get
            {
                // STEP 16a: Comment out the above Balance property and rebuild it such that the get{} includes a foreach loop that goes through the allTransactions List and tallies them up

                // STEP 16b: Declare and initialize balance
                decimal balance = 0;
                // STEP 16c: Add a foreach() loop to iterate through the allTransactions List and add each to the balance
                foreach (var t in allTransactions)
                {

                    balance += t.Amount;

                }
                // STEP 16d: Return the balance
                return balance;
            }
        }


        // STEP 6a: Build the constructor that will enable someone to open a new account (initializing a new BankAccount object) - this will have the same name as the class, and it will have a parameter for the name of the account holder, and one for the initialBalance


        // CLASS CONSTRUCTOR
        public BankAccount(string name, decimal initialBalance)
        {

            // STEP 9a: Expand the capabilities of this constructor to be able to assign a unique number to the bank account, and convert it to a string

            Number = accountNumberSeed.ToString();
            // STEP 9b: Increment the static variable accountNumberSeed so new accounts will have a unique number too - run the program to see the result, then proceed to Program.cs for STEP 10

            accountNumberSeed++;
            // STEP 6b: Set the Owner to name and the Balance to initialBalance (note the optional omission of 'this') - head back to Program.cs for STEP 7
            Owner = name;


        }

            // STEP 19: Comment out the above setting in favour of a call to the MakeDeposit method for the initial account deposit - then head over to Program.cs for STEP 20 to test the program


            // STEP 15: Add a declaration for a List collection called allTransactions to store each and every deposit and withdrawal to the acccount

            // CLASS METHODS
            
            public void MakeDeposit(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                }

                // STEP 17a: Update this method to instantiate a new Transaction object, with the appropriate arguments

                // STEP 17b: Add this new deposit to the allTransactions List collection
            }
            

           
            public void MakeWithdrawal(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
                }
                if (Balance - amount < 0)
                {
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                }

                // STEP 18a: Update this method to instantiate a new Transaction object, with the appropriate arguments

                // STEP 18b: Add this new withdrawal to the allTransactions List collection

            }
            

            // STEP 24: Uncomment the below method that iterates through the allTransactions List to output a log of the transactions associated with the bank account, then head back to Program.cs for STEP 25
            
            public string GetAccountHistory()
            {
                var report = new System.Text.StringBuilder();
                decimal balance = 0;
                report.AppendLine("Date\t\tAmount\tBalance\tNote");
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                    report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
                }
                return report.ToString();
            }
            
            // This lesson is based on the excellent tutorial at https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
            // Watch Scott and Kendra build this application at https://learn.microsoft.com/en-us/shows/csharp-101/ - Episode 16
        }
    }
