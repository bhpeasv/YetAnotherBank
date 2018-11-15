using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
