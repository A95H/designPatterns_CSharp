using BridgePattern.Interfaces;

namespace BridgePattern.Devices
{
    public class TV : Device
    {
        public void disable()
        {
            throw new System.NotImplementedException();
        }

        public void enable()
        {
            throw new System.NotImplementedException();
        }

        public int getChannel()
        {
            throw new System.NotImplementedException();
        }

        public double getVolume()
        {
            throw new System.NotImplementedException();
        }

        public bool isEnabled()
        {
            throw new System.NotImplementedException();
        }

        public void setChannel(int channel)
        {
            throw new System.NotImplementedException();
        }

        public void setVolume(double percent)
        {
            throw new System.NotImplementedException();
        }
    }
}