using System.Collections.Generic;

namespace RealizedSaleDevices.Interface
{
    public interface IDevice
    {
        static void AddRange<T>(IList<T> listOfItems)
            where T : class
        {
        }
    }
}
