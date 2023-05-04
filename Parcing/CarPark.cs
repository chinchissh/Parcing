using System;
using System.Collections.Generic;
using System.Text;

namespace Parcing
{
    class CarPark
    {
        public List<Car> ParkedCars { get; set; }

        public void PrintParkedCars()
        {
            ParkedCars.ForEach(p =>
            {
                Console.WriteLine($"{p.Producer} {p.Model} {p.Color} arrived at {p.ArrivingTime.ToShortDateString()}");
            });
        }

        public void ParkCar(Car car)
        {
            ParkedCars.Add(car);
        }
    }
}

