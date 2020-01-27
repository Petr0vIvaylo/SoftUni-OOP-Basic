using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(double weight, string bakingTechnique, string flourType)
        {
            Weight = weight;
            BakingTechnique = bakingTechnique;
            FlourType = flourType;
        }

        private double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    Exception e = new ArgumentException("Dough weight should be in the range[1..200].");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }


        private string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    Exception e = new ArgumentException("Invalid type of dough.");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                bakingTechnique = value;
            }
        }

        private string FlourType
        {
            get { return flourType; }
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    Exception e = new ArgumentException("Invalid type of dough.");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }

                flourType = value;
            }
        }
        public double CalculateDoughCallories()
        {
            double doughTypeModifier =0;
            double bakingTechniqueModifier =0 ;
            switch (this.flourType)
            {
                case "white": doughTypeModifier = 1.5; break;
                case "wholegrain": doughTypeModifier = 1.0; break;

                default:
                    break;
            }
            switch (this.bakingTechnique)
            {
                case "crispy":
                    bakingTechniqueModifier = 0.9; break;

                case "chewy":
                    bakingTechniqueModifier = 1.1; break;
                case "homemade": bakingTechniqueModifier = 1.0; break;

                default:
                    break;
            }
            double result = (2 * this.weight) * doughTypeModifier * bakingTechniqueModifier;
            return result;
        }
    }
}
