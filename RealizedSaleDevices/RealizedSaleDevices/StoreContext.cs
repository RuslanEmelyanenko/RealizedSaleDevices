using Microsoft.EntityFrameworkCore;
using RealizedSaleDevices.Models;

namespace RealizedSaleDevices
{
    public class StoreContext : DbContext
    {
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<MemorySize> Memory { get; set; }
        public DbSet<RealizedSale> RealizedSales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EMELYANENKO;Database=RealizedSaleDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Color>()
            //    .HasOne<>(s => s.)
            //    .WithMany(g => g.)
            //    .HasForeignKey(s => s.);
        }
    }
}
