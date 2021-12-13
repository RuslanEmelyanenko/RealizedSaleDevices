using System.Collections.Generic;

namespace RealizedSaleDevices.Models
{
    public class Device : Entity
    {
        public string Model { get; set; }
        //public double DisplaySize { get; set; }
        //public bool WiFi { get; set; }
        //public int RAM { get; set; }
        public double Price { get; set; }
        //public string VendorCode { get; set; }

        // ...
        public int ColorId { get; set; }
        public Color Color { get; set; }
       // ...
        public int MemorySizeId { get; set; }
        public MemorySize MemorySize { get; set; }
        // ...
        public int DeviceTypeId { get; set; }
        public DeviceType DeviceTypes { get; set; }
        // ...
        public List<RealizedSale> List { get; set; }
    }
}
