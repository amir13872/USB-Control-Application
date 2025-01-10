using System;

namespace USBControlApp.Models
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string DeviceName { get; set; }
        public string HardwareID { get; set; }
        public string Action { get; set; }
        public string PasswordStatus { get; set; }
    }
}