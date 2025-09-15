using System;

namespace classProgram
{
    // Create a Class called Bank Account
    public class BankAccount
    {
        // key Attributes of a Bank account include card number, card owner and balance.
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        private static int accountNumberSeed = 1234567890;

        // Define a constructor:
        // A constructor is a member that has the same name as the class.
        // It is used to initialize objects of that class type.
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        // Two function of the Bank account
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
