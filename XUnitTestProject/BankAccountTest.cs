using System;
using Xunit;
using YetAnotherBank;

namespace XUnitTestProject
{
    public class BankAccountTest
    {
        [Fact]
        public void CreateValidBankAccountWithZeroBalance()
        {
            int id = 1;
            BankAccount acc = new BankAccount(id);
            Assert.Equal(id, acc.Id);
            Assert.Equal(0, acc.Balance);
        }

        [Fact]
        public void CreateBankAccountWithInitialBalance()
        {
            int id = 1;
            double initialBalance = 123.45;
            BankAccount acc = new BankAccount(id, initialBalance);
            Assert.Equal(id, acc.Id);
            Assert.Equal(initialBalance, acc.Balance);

        }
    }
}
