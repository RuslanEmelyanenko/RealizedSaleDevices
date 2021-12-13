using System.Collections.Generic;
using System.Linq;
using RealizedSaleDevices.Models;

namespace RealizedSaleDevices.Repository
{
    class MemorySizeRepository
    {
        private StoreContext _dbContext;

        public MemorySizeRepository(StoreContext dbStoreContext)
        {
            _dbContext = dbStoreContext;
        }

        public MemorySize Get(int id)
        {
            var memorySize = _dbContext.Memory.Find(id);

            return memorySize;
        }

        public IList<MemorySize> GetAll()
        {
            var memorySizes = _dbContext.Memory.ToList();

            return memorySizes;
        }
    }
}
