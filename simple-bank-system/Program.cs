using System; // desnecessario na atual versão!
// static => classe sem instância.

namespace SuperBank
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Ryan", 9100);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.\n");

            account.MakeWithdrawal(3200, DateTime.Now, "TV - Smart");

            // // Test that initial balances must be positve.
            // try 
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // } 
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exeption caught creating account with negative balance!");
            //     Console.WriteLine(e.ToString());
            // }

            account.MakeWithdrawal(150, DateTime.Now, "Skyrim VR");

            Console.WriteLine(account.GetAccountHistory());

            var account2 = new BankAccount("Daniel", 2300);
            Console.WriteLine($"\nAccount {account2.Number} was created for {account2.Owner} with {account2.Balance}.\n");

            Console.WriteLine(account2.GetAccountHistory());

              
        }
    }
}
