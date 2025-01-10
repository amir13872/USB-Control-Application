public class Device
{
    public string Name { get; set; }
    public long Volume { get; set; }
    public string HardwareID { get; set; }

    public Device(string name, long volume, string hardwareID)
    {
        Name = name;
        Volume = volume;
        HardwareID = hardwareID;
    }
}