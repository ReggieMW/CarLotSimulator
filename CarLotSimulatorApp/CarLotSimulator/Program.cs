using System;

namespace CarLotSimulator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarLot reggiesAutoWorld = new CarLot();
            
            //car1 w/ dot notation
            Car bmwOne = new Car();
            bmwOne.Year = 2022;
            bmwOne.Make = "BMW";
            bmwOne.Model = "328i";
            bmwOne.EngineNoise = "vroom!";
            bmwOne.HonkNoise = "hubba!";
            bmwOne.IsDriveable = true;
            reggiesAutoWorld.Cars.Add(bmwOne);

            bmwOne.PresentCar();
            bmwOne.MakeEngineNoise();
            bmwOne.MakeHonkNoise();

            //car2 with object initializer syntax
            var ioniq = new Car()
            {
                Year = 2024,
                Make = "Hyundai",
                Model = "Ioniq 5",
                EngineNoise = "whirr",
                HonkNoise = "beep!",
                IsDriveable = true,
            };
            reggiesAutoWorld.Cars.Add(ioniq);
            
            ioniq.PresentCar();
            ioniq.MakeEngineNoise();
            ioniq.MakeHonkNoise();

            //car # w/ custom method
            var frontier = new Car(2023, "Nissan", "Frontier", "rumblebumble!", "ayhooga!", true);
            reggiesAutoWorld.Cars.Add(frontier);
            frontier.PresentCar();
            frontier.MakeEngineNoise();
            frontier.MakeHonkNoise();

            //list of cars in class CarLot
            foreach (var car in reggiesAutoWorld.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
            
        }
    }
}
