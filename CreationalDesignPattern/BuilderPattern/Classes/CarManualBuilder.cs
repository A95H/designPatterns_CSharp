using BuilderPattern.Interfaces;
using BuilderPattern.Models;

namespace BuilderPattern.Classes
{
    public class CarManualBuilder : IBuilder
    {
        public void AddGPS(bool add)
        {
            throw new System.NotImplementedException();
        }

        public Car GetProduct()
        {
            throw new System.NotImplementedException();
        }

        public void SetEngine(IEngine engine)
        {
            throw new System.NotImplementedException();
        }

        public void SetSeats(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}