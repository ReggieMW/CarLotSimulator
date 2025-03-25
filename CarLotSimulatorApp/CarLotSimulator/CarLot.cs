using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> Cars { get; set; }

    public CarLot()
    {
        Cars = new List<Car>();
    }

    public static int _numberOfCars = 0;
}