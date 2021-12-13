using System.Collections.Generic;
using System.Linq;
using RealizedSaleDevices.Models;

namespace RealizedSaleDevices.Repository
{
    class ColorRepository
    {
        private StoreContext _dbContext;

        public ColorRepository(StoreContext dbStoreContext)
        {
            _dbContext = dbStoreContext;
        }

        public Color Get(int id)
        {
            var color = _dbContext.Colors.Find(id);

            return color;
        }

        public IList<Color> GetAll()
        {
            var colors = _dbContext.Colors.ToList();

            return colors;
        }
    }
}
