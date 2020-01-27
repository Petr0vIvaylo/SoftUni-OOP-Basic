using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]));
                cars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdTokens[0] == "Drive")
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].Model == cmdTokens[1])
                        {
                            Car.Drive(cmdTokens[1], double.Parse(cmdTokens[2]), cars[i]);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            //“<Model> <fuelAmount>  <distanceTraveled>”

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
