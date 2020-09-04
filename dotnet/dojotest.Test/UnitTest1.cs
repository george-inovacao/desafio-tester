// <copyright file="UnitTest1.cs" company="George Inovation">
// Copyright (c) George Inovation. All rights reserved.
// </copyright>

using BankAccountNS;
using Xunit;

namespace Dotnet3.Test
{
    /// <summary>
    /// Main unit testing.
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// Passing test of the balance.
        /// </summary>
        [Fact]
        public void PassingTestBalance()
        {
            BankAccount ba = new BankAccount("Mr. Gomide", 4.20);
            Assert.Equal(4.20, ba.Balance);
        }

        /// <summary>
        /// Test of an empty balance.
        /// </summary>
        [Fact]
        public void EmptyBalanceTest()
        {
            BankAccount ba = new BankAccount("Mr. Gomide", 50);
            ba.Debit(ba.Balance);
            Assert.Equal(0, ba.Balance);
        }

        /// <summary>
        /// Test of credit into account.
        /// </summary>
        [Fact]
        public void PassingTestCreditBalance()
        {
            BankAccount ba = new BankAccount("Mr. Gomide", 4.20);
            ba.Credit(4.20);
            Assert.Equal(8.40, ba.Balance);
        }
    }
}
