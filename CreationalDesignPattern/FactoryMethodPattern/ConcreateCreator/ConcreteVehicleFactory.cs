using System;
using FactoryMethodPattern._ConcreateProductClasses;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.interfaces;

namespace FactoryMethodPattern.ConcreateCreator
{
    public class ConcreteVehicleFactory : VehicleFactory
    {

        public override IVehicle GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}