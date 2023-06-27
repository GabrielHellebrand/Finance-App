using System;
using System.Collections.Generic;

class SavingsAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public SavingsAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }

        Balance -= amount;
    }
}