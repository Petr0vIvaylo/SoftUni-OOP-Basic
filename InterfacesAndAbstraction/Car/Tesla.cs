using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string CarModel { get; private set; }
        public string CarColor { get; private set; }
        public int CarBattery { get; private set; }

        public Tesla(string carModel, string carColor, int carBattery)
        {
            CarModel = carModel;
            CarColor = carColor;
            CarBattery = carBattery;
        }

        public int Battery()
        {
            return this.CarBattery;
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
            string carDetails = $"{this.CarColor} {this.GetType().Name} {this.CarModel} with {this.CarBattery} Batteries";
            carDetails += Environment.NewLine + this.Start();
            carDetails += Environment.NewLine + this.Stop();
            return carDetails;
        }
    }
}
