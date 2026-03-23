using System;
using System.Collections.Generic;
using System.Text;
// STEP 11: Add this class to the same namespace as BankAccount (Classes)
namespace Classes
{
    public class Transaction
    {

        // STEP 12: Surround the below three properties and the constructor with a class declaration for Transaction

        // CLASS PROPERTIES
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        // CLASS CONSTRUCTOR
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }

        // STEP 13: Examine the above members and the constructor - well-built classes should be largely self-explanatory


        // STEP 14: We now need a way to store all of the transactions for a specific bank account - head over to the BankAccount class (STEP 15) where we will create a List collection to store these

        // This lesson is based on the excellent tutorial at https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes

        // Watch Scott and Kendra build this application at https://learn.microsoft.com/en-us/shows/csharp-101/ - Episode 16
    }
}
