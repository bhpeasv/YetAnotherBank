using System;

namespace YetAnotherBank
{
    /// <summary>
    ///     Class representing a BankAccount.
    ///     The class contains methods for 
    ///     <list type="bullet">
    ///         <term>Deposit</term> <description>Deposits a positive amount to the Bank Account</description>
    ///         <term>Withdraw></term> <description>Withdraws a positive amount from the Bank Account</description>
    ///     </list>
    ///     The class contains two constructors, one for creating a BankAccount with a zero balance,
    ///     and another for creating a BankAccount with an initial positive balance.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        ///     <value>The unique Id for the BankAccount</value>
        /// </summary>
        public int Id { get; }

        /// <summary>
        ///     <value>The current balance</value>
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        ///     Creates an instance of the BankAccount with the given <paramref name="id"/>
        ///     and <paramref name="initialBalance"/>
        /// </summary>
        /// <param name="id">
        ///     The unique identifier
        /// </param>
        /// <param name="initialBalance">
        ///     The initial balance
        /// </param>
        public BankAccount(int id, double initialBalance)
        {
            Id = id;
            Balance = initialBalance;
        }

        /// <summary>
        ///     Creates an instance of the BankAccount with the given <paramref name="id"/>
        ///     and a zero balance.
        /// </summary>
        /// <param name="id">
        ///     The unique identifier
        /// </param>
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
