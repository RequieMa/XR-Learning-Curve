using System;

namespace classProgram
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bill", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}
