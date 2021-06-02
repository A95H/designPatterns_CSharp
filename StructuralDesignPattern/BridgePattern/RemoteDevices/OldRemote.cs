using BridgePattern.Abstractions;
using BridgePattern.Interfaces;

namespace BridgePattern.RemoteDevices
{
    public class OldRemote : RemoteControl
    {
        public OldRemote(Device device) : base(device)
        {
        }

        public void Mute()
        {
            device.setVolume(0);
        }
    }
}