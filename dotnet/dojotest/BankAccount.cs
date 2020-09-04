// <copyright file="BankAccount.cs" company="George Inovation">
// Copyright (c) George Inovation. All rights reserved.
// </copyright>

using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account class.
    /// </summary>
    public class BankAccount
    {
        private BankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="customerName">The name of the customer.</param>
        /// <param name="balance">Current balance of the customer.</param>
        public BankAccount(string customerName, double balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        public string CustomerName { get; }

        /// <summary>
        /// Gets balance of the account.
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Operation to debit from the balance.
        /// </summary>
        /// <param name="amount">Amount to debit.</param>
        public void Debit(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance -= amount; // intentionally incorrect code
        }

        /// <summary>
        /// Operation to credit from the balance.
        /// </summary>
        /// <param name="amount">Amount to credit.</param>
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            Balance += amount;
        }

        /// <summary>
        /// Main function.
        /// </summary>
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}