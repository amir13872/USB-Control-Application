using System.Collections.Generic;

namespace USBControlApp.Models
{
    public class Config
    {
        public string PasswordHash { get; set; }
        public List<string> TrustedDevices { get; set; }
        public string ProgramStatus { get; set; }
    }
}