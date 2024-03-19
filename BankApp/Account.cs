using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Account
    {
        private readonly string accountNumber;
        private double balance;
        private AccountType type;

        // Default constructor for checking account
        public Account() : this("DefaultAccountNumber", 0, AccountType.Checking)
        {
        }

        // Constructor with account number, balance, and type
        public Account(string accountNumber, double balance, AccountType type)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.type = type;
        }

        // Constructor with only account number (assumes default values for balance and type)
        public Account(string accountNumber) : this(accountNumber, 0, AccountType.Checking)
        {
        }

        // Properties
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public AccountType Type
        {
            get { return type; }
        }

        // Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid deposit amount.");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && balance - amount >= 0)
                balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }

        // Overloaded methods for convenience
        public void Deposit(int amount)
        {
            Deposit((double)amount);
        }

        public void Withdraw(int amount)
        {
            Withdraw((double)amount);
        }

        public void Deposit(decimal amount)
        {
            Deposit((double)amount);
        }

        public void Withdraw(decimal amount)
        {
            Withdraw((double)amount);
        }
    }

    // Enum for Account Type
    public enum AccountType
    {
        Checking,
        Savings
    }
}
