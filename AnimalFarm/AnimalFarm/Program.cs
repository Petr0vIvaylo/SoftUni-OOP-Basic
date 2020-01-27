﻿namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine(
                $"Chicken {chicken.GetName()} (age {chicken.GetAge()}) can produce {chicken.ProductPerDay} eggs per day.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}
