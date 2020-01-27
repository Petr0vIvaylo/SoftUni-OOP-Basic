using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        //model, fuel amount, fuel consumption for 1 kilometer and  traveled distance

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double DistanceTraveled { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.DistanceTraveled = 0;
        }

        public static void Drive(string model, double amountOfKm, Car car)
        {

            if (car.FuelAmount >= amountOfKm * car.FuelConsumption)
            {
                car.DistanceTraveled += amountOfKm;
                car.FuelAmount -= amountOfKm * car.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
