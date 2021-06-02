using BuilderPattern.CarParts;
using BuilderPattern.Interfaces;
using BuilderPattern.Models;

namespace BuilderPattern.Classes
{
    public class Director
    {
        private IBuilder builder;

        public Car ConstructSUV(IBuilder builder)
        {
            builder.SetEngine(new CarEngine());
            builder.SetSeats(6);
            builder.AddGPS(true);
            builder.GetProduct();
            return builder.GetProduct();
        }
    }
}