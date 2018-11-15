using System;

namespace YetAnotherBank
{
    public class BankAccount
    {
        public int Id { get; }
        public double Balance { get; private set; }

        public BankAccount(int id, double initialBalance)
        {
            Id = id;
            Balance = initialBalance;
        }

        public BankAccount(int id)
        : this(id, 0.0)
        {
        }

        /// <summary>
        /// Adds the <paramref name="amount"/> to the balance of the bank account.
        /// If the <paramref name="amount"/> is not greater than zero, an ArgumentException is thrown.
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException">
        /// Thrown is the <paramref name="amount"/> is not greater than zero
        /// </exception>
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero");
            }
            Balance += amount;
        }
    }
}
