using System;

namespace CarLotSimulator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();
            Console.WriteLine($"{CarLot._numberOfCars}");
            
            //car1 w/ dot notation
            Car bmwOne = new Car(2022, "BMW", "328i", "vroom!", "hubba!", true);
            bmwOne.Year = 2022;
            bmwOne.Make = "BMW";
            bmwOne.Model = "328i";
            bmwOne.EngineNoise = "vroom!";
            bmwOne.HonkNoise = "hubba!";
            bmwOne.IsDriveable = true;
            carLot.Cars.Add(bmwOne);
            
            bmwOne.PresentCar();
            bmwOne.MakeEngineNoise();
            bmwOne.MakeHonkNoise();
            Console.WriteLine(CarLot._numberOfCars);

            //car2 with object initializer syntax
            var ioniq = new Car(2024, "Hyundai", "Ioniq 5", "whirr", "beep!", true);
            carLot.Cars.Add(ioniq);
            ioniq.PresentCar();
            ioniq.MakeEngineNoise();
            ioniq.MakeHonkNoise();
            Console.WriteLine(CarLot._numberOfCars);

            //car # w/ custom method
            var frontier = new Car(2023, "Nissan", "Frontier", "rumblebumble!", "ayhooga!", true);
            carLot.Cars.Add(frontier);
            frontier.PresentCar();
            frontier.MakeEngineNoise();
            frontier.MakeHonkNoise();
            Console.WriteLine(CarLot._numberOfCars);

            //list of cars in class CarLot
            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
            
        }
    }
}
