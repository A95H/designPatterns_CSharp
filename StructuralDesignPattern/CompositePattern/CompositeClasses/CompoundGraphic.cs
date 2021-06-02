using System;
using System.Collections;
using System.Collections.Generic;
using CompositePattern.Interfaces;

namespace CompositePattern.CompositeClasses
{
    public class CompoundGraphic : Graphic
    {
        List<Graphic> list = new List<Graphic>();
        void Add(Graphic graphic)
        {
            list.Add(graphic);
        }
        void Remove(Graphic graphic)
        {
            list.Remove(graphic);
        }
        public void Draw()
        {
            // draw all children
            Console.WriteLine("Draw all children");
        }

        public void Move(double x, double y)
        {
            // move all children
            Console.WriteLine("Move all children");
        }
    }
}