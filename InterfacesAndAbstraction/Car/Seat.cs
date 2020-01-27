using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string CarModel { get; private set; }
        public string CarColor { get; private set; }

        public Seat(string model, string color)
        {
            this.CarModel = model;
            this.CarColor = color;
        }

        public string Color()
        {
            return this.CarColor;
        }

        public string Model()
        {
            return this.CarModel;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            string carDetails = this.CarColor + " " + this.GetType().Name + " " + this.CarModel;
            carDetails += Environment.NewLine + this.Start();
            carDetails += Environment.NewLine + this.Stop();
            return carDetails;
        }
    }
}
