using System;
using FactoryMethodPattern.ConcreateCreator;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.interfaces;

/* 

https://refactoring.guru/design-patterns/factory-method 

In Factory pattern, we create the object without exposing the creation logic. In this pattern,
an interface is used for creating an object, but let subclass decide which class to instantiate.
The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.

In short, factory method design pattern abstract the process of object creation 
and allows the object to be created at run-time when it is required.
*/
namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();
            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(20);
        }
    }
}
