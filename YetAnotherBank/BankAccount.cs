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
        ///     Adds the <paramref name="amount"/> to the balance of the bank account.
        ///     If the <paramref name="amount"/> is not greater than zero, an ArgumentException is thrown.
        /// </summary>
        /// <param name="amount">
        ///     The amont to deposit
        /// </param>
        /// <exception cref="ArgumentException">
        ///     Thrown if the <paramref name="amount"/> is not greater than zero
        /// </exception>
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero");
            }
            Balance += amount;
        }

        /// <summary>
        ///     Subtracts the <paramref name="amount"/> from the current balance of the bank account. 
        ///     Throws an ArgumentException, if the amount is not greater than zero, or if the amount
        ///     exceeds the current balance.
        /// </summary>
        /// <param name="amount">
        ///     The amount to withdraw
        /// </param>
        /// <exception cref="ArgumentException">
        ///     if the <paramref name="amount"/> is not greater than zero, or if the 
        ///     <paramref name="amount"/> exceeds the current balance
        /// </exception>
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("Amount cannot exceed the balance");
            }
            Balance -= amount;
        }
    }
}
