using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        private string Type
        {
            get => type;
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    Exception e = new ArgumentException($"Cannot place {value} on top of your pizza.");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                type = value;
            }
        }
        private double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    Exception e = new ArgumentException($"{type} weight should be in the range [1..50].");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }
        public double CalculateTopingCallories()
        {
            double toppingType = 0;
            
            switch (this.type)
            {
                case "meat": toppingType = 1.2; break;
                case "veggies": toppingType = 0.8; break;
                case "cheese": toppingType = 1.1; break;
                case "sauce": toppingType = 0.9; break;

                default:
                    break;
            }
            
            double result = (2 * this.weight) * toppingType;
            return result;
        }
    }
}
