using System;
using CompositePattern.Interfaces;

namespace CompositePattern.Leaf
{
    /*
    
    The leaf class represents end objects of a composition. A
    leaf object can't have any sub-objects. Usually, it's leaf
    objects that do the actual work, while composite objects only
    delegate to their sub-components.
*/
    public class Dot : Graphic
    {
        public double x, y;
        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Console.WriteLine("Draw Dot");
        }

        public void Move(double x, double y)
        {
            Console.WriteLine("Move");
        }
    }
}