using Account.Exceptions.Entities;

namespace Account.Entities
{
    class Account
    {
        public int Number { get; set; }

        public string Holder { get; set; }

        public double Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawLimit;
        }

        public void withdraw(double amount)
        {
            if (amount > this.WithdrawLimit)
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");

            if (amount > this.Balance)
                throw new DomainException("Withdraw error: Not enough balance");

            this.Balance -= amount;            

        }
    }
}