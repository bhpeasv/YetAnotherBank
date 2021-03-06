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

        [Fact]
        public void DepositValidAmount()
        {
            double initialBalance = 123.45;
            double amount = 0.01;
            double expected = initialBalance + amount;
            BankAccount acc = new BankAccount(1, initialBalance);

            acc.Deposit(amount);

            Assert.Equal(expected, acc.Balance);
        }

        [Theory]
        [InlineData(0.00)]
        [InlineData(-0.01)]
        public void DepositInvalidAmountExceptArgumentException(double amount)
        {
            double initialBalance = 123.45;
            BankAccount acc = new BankAccount(1, initialBalance);
            var ex = Assert.Throws<ArgumentException>(() => acc.Deposit(amount));
            Assert.Equal("Amount must be greater than zero", ex.Message);
        }

        [Theory]
        [InlineData(123.45, 0.01)]
        [InlineData(123.45, 123.45)]
        public void WithdrawValidAmount(double initialBalance, double amount)
        {
            double expected = initialBalance - amount;
            BankAccount acc = new BankAccount(1, initialBalance);
            acc.Withdraw(amount);
            Assert.Equal(expected, acc.Balance);
        }

        [Theory]
        [InlineData(123.45, 0.00, "Amount must be greater than zero")]
        [InlineData(123.45, -0.01, "Amount must be greater than zero")]
        [InlineData(123.45, 123.46, "Amount cannot exceed the balance")]
        public void WithdrawInvalidAmountExpectArgumentException(double initialBalance, double amount, string message)
        {
            BankAccount acc = new BankAccount(1, initialBalance);
            var ex = Assert.Throws<ArgumentException>(() => acc.Withdraw(amount));
            Assert.Equal(message, ex.Message);
        }
    }
}
