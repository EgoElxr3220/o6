using System;
using System.Collections.Generic;
using System.Text;
using CarSpace;

namespace CarUtilities
{
    public static class CarUtilities
    {
        public static void DisplayCar(Car car)
        {
            Console.WriteLine($"Model: {car.Model}\nSpeed: {car.Speed}");
        }
    }
}
