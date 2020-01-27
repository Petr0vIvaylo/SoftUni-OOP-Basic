using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class RawData
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int carAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carAmount; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = inputData[0];
                int engineSpeed = int.Parse(inputData[1]);
                int enginePower = int.Parse(inputData[2]);
                int cargoWeight = int.Parse(inputData[3]);
                string cargoType = inputData[4];
                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < inputData.Length; j += 2)
                {

                    Tire tire = new Tire(double.Parse(inputData[j]), int.Parse(inputData[j + 1]));
                    tires.Add(tire);
                }

                Car currentCar = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), tires);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tire.Any(s => s.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }

            }
        }
    }
}
