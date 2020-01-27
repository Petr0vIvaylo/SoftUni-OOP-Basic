using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception e = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);

                }
                name = value;

            }
        }
        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value < 0)
                {
                    Exception e = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                cost = value;
            }
        }

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
