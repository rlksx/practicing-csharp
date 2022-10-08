namespace SuperBank
{
    class Transation {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Transation(decimal amount, DateTime date, string note) {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;
        }
    }
}