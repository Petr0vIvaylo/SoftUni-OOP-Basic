using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private  decimal balance;

        public int Id { get; set; }
        public decimal Balance { get; set; }


        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.Balance -= amount;
            }
            
        }
       

    }
}
