using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var carTokens = Console.ReadLine().Split();
                var model = carTokens[0];
                var fuelAmount = double.Parse(carTokens[1]);
                var consumption = double.Parse(carTokens[2]);

                var car = new Car
                {
                    Model = model,
                    FuelAmout = fuelAmount,
                    FuelConsumption = consumption
                };

                cars.Add(model, car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();
                var model = tokens[1];
                var distance = int.Parse(tokens[2]);

                var currCar = cars[model];
                currCar.Drive(distance);

                cars[model] = currCar;
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmout:f2} {car.Value.DistanceTravelled}");
            }
        }
    }
}
