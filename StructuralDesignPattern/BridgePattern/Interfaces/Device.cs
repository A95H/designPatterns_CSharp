namespace BridgePattern.Interfaces
{
    public interface Device
    {
        bool isEnabled();
        void enable();
        void disable();
        double getVolume();
        void setVolume(double percent);
        int getChannel();
        void setChannel(int channel);
    }
}