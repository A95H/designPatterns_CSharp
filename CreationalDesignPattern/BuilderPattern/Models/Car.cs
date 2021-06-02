using BuilderPattern.Interfaces;

namespace BuilderPattern.Models
{
    public class Car
    {
        public int Seats { get; set; }
        public IEngine Engine { get; set; }
        public bool HasGPS { get; set; }
    }
}