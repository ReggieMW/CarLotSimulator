using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }
    
    public void MakeEngineNoise()
    {
        Console.WriteLine($"Engine: {EngineNoise}");
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine($"Horn noise: {HonkNoise}");
    }
    public void PresentCar()
    {
        Console.WriteLine($"This is a {Year} {Make} {Model}. Listen to that baby purr! ::{EngineNoise}:: Shall I draw up the paperwork? ::{HonkNoise}::");
    } 
    
    //custom constructor
    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;

        CarLot._numberOfCars++;
    }

    public Car()
    {
        
    }
}
