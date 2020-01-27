using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Topping> toppings = new List<Topping>();
            string pizzaName = string.Empty;
            string doughFlour = string.Empty;
            string doughType = string.Empty;
            double doughtWeight = 0;
            string toppingType = string.Empty;
            double toppingWeight = 0;

            string input = Console.ReadLine();

            while (input != "END")
            {


                if (input.Contains("Pizza"))
                {
                    pizzaName = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                }
                else if (input.Contains("Dough"))
                {
                    string[] doughParams = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    doughFlour = doughParams[1].ToLower();
                    doughType = doughParams[2].ToLower();
                    doughtWeight = double.Parse(doughParams[3]);
                    
                }
                else if (input.Contains("Topping"))
                {
                    string[] toppingParams = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    toppingType = toppingParams[1].ToLower();
                    toppingWeight = double.Parse(toppingParams[2]);
                    Topping topping = new Topping(toppingType, toppingWeight);
                    toppings.Add(topping);
                }
                input = Console.ReadLine();
            }

            Dough dough = new Dough(doughtWeight, doughType, doughFlour);
            

            Pizza pizza = new Pizza(pizzaName, toppings, dough);

            Console.WriteLine($"{pizza.GetName()} - {pizza.TotalCalories():F2} Calories.");
        }
    }
}
