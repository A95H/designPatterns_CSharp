using System;
using CompositePattern.Leaf;

namespace CompositePattern.Components
{
    // All component classes can extend other components.

    public class Circle : Dot
    {
        double radius;
        public Circle(double radius, double x, double y) : base(x, y)
        {
            this.radius = radius;
        }
        new void Draw()
        {
            Console.WriteLine("Draw Cicle");
        }
    }
}