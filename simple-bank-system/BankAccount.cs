using System; // desnecessario na atual versão!
using System.Collections.Generic; // desnecessario na atual versão!
using System.Text; // usado para o string builder!

namespace SuperBank
{
    class BankAccount 
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get{
                decimal balance = 0;
                 foreach (var item in allTransations) 
                    balance += item.Amount;
                return balance;
            }   
        }
        // calculando o valor na que possuí na conta.
        private static int accountNumberSeed = 1;

        private List<Transation> allTransations = new List<Transation>();
        // lista da classe Transation que recebe todas transações (historico de transações)
        // possui valor, data da transação e nota.

        public BankAccount(string name, decimal initinalBalance) 
        {
            this.Owner = name;
            MakeDeposit(initinalBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) 
                throw new ArgumentOutOfRangeException( nameof( amount ), "Amount deposit must be positive!" );
                // ArgumentOutOfRangeException => enterrompe a execução!
            var deposit = new Transation(amount, date, note); // instânciando um obj da classe de transações
            allTransations.Add(deposit); // colocando objeto dentro da coleção.
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note )
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException( nameof( amount ), "Amount of wothdraw must be  positive!" );
            if (Balance - amount < 0)
                throw new ArgumentOutOfRangeException( nameof( amount ), "Not sufficient funds for this withdraw!" );
            var withdraw = new Transation(-amount, date, note);
            allTransations.Add(withdraw);
        }

        public string GetAccountHistory() 
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");

            // Header
            foreach (var item in allTransations)
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Note}");

            return report.ToString();
        }
    }
}