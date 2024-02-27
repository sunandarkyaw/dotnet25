using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using SystemAPI.Model;

namespace SystemAPI.Entity
{
    public class SensorDbContext : DbContext
    {

        public SensorDbContext(DbContextOptions<SensorDbContext> dbContextOptions)
        : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PowerData>().HasNoKey();
            modelBuilder.Entity<SensorData>()
       .HasKey(s => s.id);
            modelBuilder.Entity<SensorData>().Ignore(s => s.data);
        }

        public DbSet<SensorData> SensorData { get; set; }
    }

}
