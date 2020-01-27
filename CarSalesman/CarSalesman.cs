using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class CarSalesman
    {
       public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineSpec = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = engineSpec[0];
                int enginePower = int.Parse(engineSpec[1]);
                string displacement = "n/a";
                string efficiency = "n/a";
                
                if (engineSpec.Length >= 3)
                {
                    
                    if (char.IsDigit(engineSpec[2][0]))
                    {
                        displacement = engineSpec[2];
                    }
                    else
                    {
                        efficiency = engineSpec[2];
                    }
                }
                if (engineSpec.Length == 4)
                {
                    efficiency = engineSpec[3];
                }
                if (displacement == "n/a" && efficiency == "n/a")
                {
                    Engine engine = new Engine(model, enginePower);
                    engines.Add(engine);
                }
                else if (displacement != "n/a" && efficiency == "n/a")
                {
                    Engine engine = new Engine(model, enginePower, displacement);
                    engines.Add(engine);
                }
                else if (displacement == "n/a" && efficiency != "n/a")
                {
                    Engine engine = new Engine()
                    {
                        Model = model,
                        Power = enginePower,
                        Displacement = displacement,
                        Efficiency = efficiency
                    };
                    engines.Add(engine);
                }
                else if (displacement != "n/a" && efficiency != "n/a")
                {
                    Engine engine = new Engine(model, enginePower, displacement, efficiency);
                    engines.Add(engine);
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int j = 0; j < numberOfCars; j++)
            {
                string[] currentCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = currentCar[0];
                string engineModel = currentCar[1];
                string weight = "n/a";
                string color = "n/a";
                if (currentCar.Length >= 3)
                {
                    if (char.IsDigit(currentCar[2][0]))
                    {
                        weight = currentCar[2];
                    }
                    else
                    {
                        color = currentCar[2];
                    }
                }
                if (currentCar.Length == 4)
                {
                    color = currentCar[3];
                }
                if (weight == "n/a" && color == "n/a")
                {
                    for (int i = 0; i < engines.Count; i++)
                    {
                        if (engines[i].Model == engineModel)
                        {
                            Car car = new Car(carModel, engines[i]);
                            cars.Add(car);
                            break;
                        }
                    }
                    
                }
                else if (weight != "n/a" && color == "n/a")
                {
                    for (int i = 0; i < engines.Count; i++)
                    {
                        if (engines[i].Model == engineModel)
                        {
                            Car car = new Car(carModel, engines[i], weight);
                            cars.Add(car);
                        }
                    }
                }
                else if (weight == "n/a" && color != "n/a")
                {
                    for (int i = 0; i < engines.Count; i++)
                    {
                        if (engines[i].Model == engineModel)
                        {
                            Car car = new Car()
                            {
                                Model = carModel,
                                Engine = engines[i],
                                Color = color,
                                Weight = weight
                            };
                            cars.Add(car);
                        }
                    }
                }
                else if (weight != "n/a" && color != "n/a")
                {
                    for (int i = 0; i < engines.Count; i++)
                    {
                        if (engines[i].Model == engineModel)
                        {
                            Car car = new Car(carModel, engines[i], weight, color);
                            cars.Add(car);
                        }
                    }
                }
            }
            
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
