using System;
using FactoryMethodPattern.interfaces;

namespace FactoryMethodPattern._ConcreateProductClasses
{
    public class Scooter : IVehicle
    {
        public void Drive(int km)
        {
            Console.WriteLine("This Scooter Drive " + km + "KM");
        }
    }
}