using System;
using Xunit;
using BankAccountNS;

namespace dotnet3.Test
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTestBalance()
        {
            BankAccount ba = new BankAccount("Mr. Gomide", 4.20);
            Assert.Equal(4.20, ba.Balance);
        }

        [Fact]
        public void EmptyBalanceTest()
        {
            BankAccount ba = new BankAccount("Mr. Gomide", 50);
            ba.Debit(ba.Balance);
            Assert.Equal(0, ba.Balance);
        }

        [Fact]
        public void PassingTestDeBadImageFormatException()
        {
            BankAccount ba = new BankAccount("Mr. Gomide", 4.20);
            ba.Credit(4.20);
            Assert.Equal(8.40, ba.Balance);
        }
    }
}
