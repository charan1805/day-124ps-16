using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment_16
{
  
        internal class BankAccount
        {


            private static int accountCounter = 1000;
            public int AccountNumber { get; }
            public string AccountHolderName { get; }
            private double Balance { get; set; }

            public BankAccount(string accountHolderName)
            {
                AccountNumber = GenerateAccountNumber();
                AccountHolderName = accountHolderName;
                Balance = 0;
            }

            private static int GenerateAccountNumber()
            {
                return ++accountCounter;
            }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be greater than zero.");
                }

                Balance += amount;
            }
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be greater than zero.");
                }

                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }

                Balance -= amount;
            }
            public double GetBalance()
            {
                return Balance;
            }
        }
    }


