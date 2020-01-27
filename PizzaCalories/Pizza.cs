using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, List<Topping> toppings, Dough dough)
        {
            Name = name;
            Toppings = toppings;
            Dough = dough;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    Exception e = new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public List<Topping> Toppings
        {
            get => toppings;
            set
            {
                if (value.Count > 10)
                {
                    Exception e = new ArgumentException("Number of toppings should be in range [0..10].");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                toppings = value;
            }
        }
        public Dough Dough { get => dough; set => dough = value; }

        public double TotalCalories()
        {
            double doughtCalories = dough.CalculateDoughCallories();
            double toppingCalories = 0;

            foreach (var item in toppings)
            {
                toppingCalories += item.CalculateTopingCallories();
            }
            return toppingCalories + doughtCalories;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
