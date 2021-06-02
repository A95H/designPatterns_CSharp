using BridgePattern.Abstractions;
using BridgePattern.Interfaces;

namespace BridgePattern.RemoteDevices
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }
        public void mute()
        {
            base.device.setVolume(0);
        }
    }
}