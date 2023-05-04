using System;
using System.Collections.Generic;

namespace Parcing//Лабораторная работа по Мищенко №4
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new CarPark
            {
                ParkedCars = new List<Car>
                {
                    new Car
                    {
                        ArrivingTime = new DateTime(2023, 02, 27),
                        Color = "Dark-Blue",
                        Model = "Rolls-Royce",
                        Producer = "BMW",
                        StateNumber = "M DJ6823"
                    },
                    new Car
                    {
                        ArrivingTime = new DateTime(2023, 02, 25),
                        Color = "Black",
                        Model = "Mercedes-Benz",
                        Producer = "Mercedes",
                        StateNumber = "S MB1035"
                    },
                    new Car
                    {
                        ArrivingTime = new DateTime(2023, 03, 02),
                        Color = "White",
                        Model = "Suzuki",
                        Producer = "Suzuki",
                        StateNumber = "N SP3600"
                    },
                }
            };

            Console.WriteLine("Parked Cars:");

            parking.PrintParkedCars();

            Console.WriteLine("\n \nEnter a car data:");

            Console.WriteLine("Producer");
            var producer = Console.ReadLine();

            Console.WriteLine("Model");
            var model = Console.ReadLine();

            Console.WriteLine("Color");
            var color = Console.ReadLine();

            Console.WriteLine("StateNumber");
            var stateNumber = Console.ReadLine();

            parking.ParkCar(new Car
            {
                ArrivingTime = DateTime.Now,
                Color = color,
                Model = model,
                Producer = producer
            });

            Console.WriteLine("\n \nParked Cars:");

            parking.PrintParkedCars();


            Console.ReadKey();
        }
    }
}

