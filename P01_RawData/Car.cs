using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        public Car(string model, Engine engine, List<Tire> tires , Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Tire = tires;
            this.Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public List<Tire> Tire { get; set; }
        public Cargo Cargo { get; set; }
    }
}
