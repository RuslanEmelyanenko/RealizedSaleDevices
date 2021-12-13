using System.Collections.Generic;
using System.Linq;
using RealizedSaleDevices.Models;

namespace RealizedSaleDevices.Repository
{
    class DeviceTypeRepository
    {
        private StoreContext _dbContext;

        public DeviceTypeRepository(StoreContext dbStoreContext)
        {
            _dbContext = dbStoreContext;
        }

        public DeviceType Get(int id)
        {
            var deviceType = _dbContext.DeviceTypes.Find(id);

            return deviceType;
        }

        public IList<DeviceType> GetAll()
        {
            var deviceTypes = _dbContext.DeviceTypes.ToList();

            return deviceTypes;
        }
    }
}
