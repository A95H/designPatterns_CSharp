using FactoryMethodPattern.interfaces;

namespace FactoryMethodPattern.Creator
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string Vehicle);
        
    }
}