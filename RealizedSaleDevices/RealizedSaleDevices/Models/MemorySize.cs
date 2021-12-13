using System.Collections.Generic;

namespace RealizedSaleDevices.Models
{
    public class MemorySize : Entity
    {
        public int MemorySizeDevice { get; set; }

        public List<Device> Devices { get; set; }
    }
}
