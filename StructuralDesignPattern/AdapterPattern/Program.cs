using System;
using AdapterPattern.Adapters;
using AdapterPattern.Classes;

/*
    Adapter is a structural design pattern that allows objects 
    with incompatible interfaces to collaborate.
*/

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            Adapter adapter = new Adapter(adaptee);
            Console.WriteLine(adapter.GetRequest());
        }
    }
}
