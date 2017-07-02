using System;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (this.balance + value < 0)
                {
                    throw new ArgumentException("Balance negative!");
                }
                this.balance = value;
            }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }


        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance:f2}";
        }
    }
}