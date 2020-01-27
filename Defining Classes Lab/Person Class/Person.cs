using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount> Accounts { get; set; }

        public Person(string name, int age)
        : this(name, age, new List<BankAccount>())
        {
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        public decimal GetBalance()
        {
            return this.accounts.Sum(x => x.Balance);
        }
    }
}
