using System.Collections.Generic;
using System.Linq;
using RealizedSaleDevices.Models;

namespace RealizedSaleDevices.Repository
{
    class DeviceRepository
    {
        private StoreContext _dbContext;

        public DeviceRepository(StoreContext dbStoreContext)
        {
            _dbContext = dbStoreContext;
        }

        public Device Get(int id)
        {
            var device = _dbContext.Devices.Find(id);

            return device;
        }

        public IList<Device> GetAll()
        {
            var devices = _dbContext.Devices.ToList();

            return devices;
        }
    }
}
