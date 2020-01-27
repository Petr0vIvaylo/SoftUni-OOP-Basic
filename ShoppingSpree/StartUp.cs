using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] people = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < people.Length - 1; i+=2)
            {
                string name = people[i];
                decimal money = decimal.Parse(people[i + 1]);
               
                    Person person = new Person(name, money);
                    persons.Add(person);
                
               
            }

            string[] ingredients = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < ingredients.Length - 1; i += 2)
            {
                string productName = ingredients[i];
                decimal productCost = decimal.Parse(ingredients[i + 1]);
                Product product = new Product(productName, productCost);
                products.Add(product);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] cmdTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = cmdTokens[0];
                string productName = cmdTokens[1];

                foreach (var p in persons)
                {
                    if (personName == p.GetPersonName())
                    {
                        foreach (var product in products)
                        {
                            if (productName == product.Name)
                            {
                                p.BuyProduct(product);
                                break;
                            }
                        }
                    }
                    
                }
                command = Console.ReadLine();
            }
            foreach (var person in persons)
            {
                if (person.bag.Count > 0)
                {
                    Console.WriteLine($"{person.GetPersonName()} - {string.Join(", ",person.bag)}");
                }
                else
                {
                    Console.WriteLine($"{person.GetPersonName()} - Nothing bought");
                }
            }
        }
    }
}
