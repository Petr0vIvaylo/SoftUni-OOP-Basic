using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class StartUp

    {
        public static void Main(string[] args)
        {
            Dictionary<int,BankAccount> accounts = new Dictionary<int, BankAccount>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Create":
                        Create(int.Parse(cmdArgs[1]), accounts);
                        break;
                    case "Deposit":
                        Deposit(int.Parse(cmdArgs[1]), decimal.Parse(cmdArgs[2]), accounts);
                        break;
                    case "Withdraw":
                        Withdraw(int.Parse(cmdArgs[1]), decimal.Parse(cmdArgs[2]), accounts);
                        break;
                    case "Print":
                        Print(int.Parse(cmdArgs[1]), accounts);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            
        }
        public static void Print(int id, Dictionary<int, BankAccount> acc)
        {
            if (acc.ContainsKey(id))
            {
                Console.WriteLine($"Account ID{id}, balance {acc.GetValueOrDefault(id).Balance:f2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }
        public static void Create(int id, Dictionary<int, BankAccount> acc)
        {
            if (!acc.ContainsKey(id))
            {
                acc[id] = new BankAccount();
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
        public static void Deposit(int id, decimal amount, Dictionary<int, BankAccount> acc)
        {
            if (!acc.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                acc[id].Deposit(amount);
            }
        }
        public static void Withdraw(int id, decimal amount, Dictionary<int, BankAccount> acc)
        {
            if (!acc.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                acc[id].Withdraw(amount);
            }
        }
    }
}
