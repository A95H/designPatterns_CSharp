using System;
using AdapterPattern.Classes;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters
{
    // An adapter class lets you fit square pegs into round holes.
    // It extends the RoundPeg class to let the adapter objects act
    // as round pegs.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;


        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}