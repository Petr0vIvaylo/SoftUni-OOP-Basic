using MordorsCruelPlan.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.FoodFactories
{
    public class FoodFactory
    {
        public Food CreateFood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "cram": return new Cram();
                case "lembas": return new Lembas();
                case "apple": return new Apple();
                case "melon": return new Melon();
                case "mushrooms": return new Mushrooms();
                case "honeycake": return new HoneyCake();
                default:
                case "junkfood":
                    return new JunkFood();
                    
            }
        }
    }
}
