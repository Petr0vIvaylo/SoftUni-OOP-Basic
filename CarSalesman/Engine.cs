using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        
        public string Model{ get; set; }
        public int Power{ get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {

        }
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, string displacement)
            :this(model, power)
        {
            this.Displacement = displacement;
            
        }

        public Engine(string model, int power, string displacement, string efficiency)
            : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }
    }
}
