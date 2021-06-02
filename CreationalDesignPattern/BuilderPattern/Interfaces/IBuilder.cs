using BuilderPattern.Models;

namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
         void SetSeats(int number);
         void SetEngine(IEngine engine);
         void AddGPS(bool add);
         Car GetProduct();
         
    }
}