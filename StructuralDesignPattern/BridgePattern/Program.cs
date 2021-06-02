using System;
using BridgePattern.Devices;
using BridgePattern.RemoteDevices;
/*
https://refactoring.guru/design-patterns/bridge

Bridge is a structural design pattern that lets you split a large class or a set of closely related classes 
into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
*/
namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Radio radio = new Radio();
            AdvancedRemoteControl advanedTVRemote = new AdvancedRemoteControl(tv);
            OldRemote oldRadioRemote = new OldRemote(radio);

            advanedTVRemote.mute();
            oldRadioRemote.Mute();
        }
    }
}
