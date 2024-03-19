using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating accounts
            Account checkingAccount = new Account("10202103423", 1000, AccountType.Checking);
            Account savingsAccount = new Account("102331234520", 500, AccountType.Savings);

            // Displaying account details
            Console.WriteLine("Checking Account Details:");
            PrintAccountDetails(checkingAccount);
            Console.WriteLine("Savings Account Details:");
            PrintAccountDetails(savingsAccount);

            // Depositing and withdrawing money
            checkingAccount.Deposit(500);
            savingsAccount.Withdraw(200);

            // Displaying updated account details
            Console.WriteLine("\nUpdated Checking Account Details:");
            PrintAccountDetails(checkingAccount);
            Console.WriteLine("Updated Savings Account Details:");
            PrintAccountDetails(savingsAccount);
        }

        static void PrintAccountDetails(Account account)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: ${account.Balance}");
            Console.WriteLine($"Account Type: {account.Type}");
            Console.WriteLine();
        }
    }
}
