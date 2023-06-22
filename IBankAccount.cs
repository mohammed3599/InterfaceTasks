using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IBankAccount
    {
        double GetBalance();
        void Deposit(double amount);
        void Withdraw(double amount);
    }

    class SavingsAccount : IBankAccount
    {
        private double balance;

        public SavingsAccount()
        {
            balance = 0;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Money.");
            }
        }
    }

    class CheckingAccount : IBankAccount
    {
        private double balance;

        public CheckingAccount()
        {
            balance = 0;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
