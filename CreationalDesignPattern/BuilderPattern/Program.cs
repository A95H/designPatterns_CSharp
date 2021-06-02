using System;
using BuilderPattern.Classes;
using BuilderPattern.Models;
/*
https://refactoring.guru/design-patterns/builder

The Builder pattern lets you build objects step by step,
using only those steps that you really need.
After implementing the pattern,
you don’t have to cram dozens of parameters into your constructors anymore.
The Builder pattern can be applied when construction of various representations of the product involves similar steps that differ only in the details.
*/
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            CarBuilder carBuilder = new CarBuilder();
            Car car = director.ConstructSUV(carBuilder);
        }
    }
}
