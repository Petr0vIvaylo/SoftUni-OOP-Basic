using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public Car()
        {

        }
        public Car(string model, Engine engine, string weight)
            :this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string weight, string color)
            :this(model, engine, weight)
        {
            this.Color = color;
        }
    }
}
