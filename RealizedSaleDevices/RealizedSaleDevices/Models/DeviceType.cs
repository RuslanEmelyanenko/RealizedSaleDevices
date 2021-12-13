using System.Collections.Generic;

namespace RealizedSaleDevices.Models
{
    public class DeviceType : Entity
    {
        public string Type { set; get; } 
        
        // ...
        public List<Device> Devices { get; set; }
    }
}
