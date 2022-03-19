using System;

namespace BankyStuffLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
 

            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} USD");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "second");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());


            //Test for a negative balance:
            try
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Execption caught trying to overdraw");
                //Console.WriteLine(e.ToString());
            }
            
            
            // test that the initial balances must be positive
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exeption caught creating account with negative balance");
                //Console.WriteLine(e.ToString());
            }
            Console.WriteLine(account.Balance);
        
        }
    }
}
