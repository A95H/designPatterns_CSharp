using System;
using FactoryMethodPattern.interfaces;

namespace FactoryMethodPattern._ConcreateProductClasses
{
    public class Bike : IVehicle
    {
        public void Drive(int km)
        {
            Console.WriteLine("This Bike Drive " + km + "KM");
        }
    }
}