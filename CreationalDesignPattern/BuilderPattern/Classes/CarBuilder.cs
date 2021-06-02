using BuilderPattern.Interfaces;
using BuilderPattern.Models;

namespace BuilderPattern.Classes
{
    public class CarBuilder : IBuilder
    {
        private Car car;

        public CarBuilder()
        {
            this.car = new Car();
        }

        public void AddGPS(bool add)
        {
            car.HasGPS = add;
        }

        public Car GetProduct()
        {
            return car;
        }

        public void SetEngine(IEngine engine)
        {
            car.Engine = engine;
        }

        public void SetSeats(int number)
        {
            car.Seats = number;
        }
    }
}