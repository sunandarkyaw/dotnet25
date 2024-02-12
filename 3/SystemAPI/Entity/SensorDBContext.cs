using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using SystemAPI.Model;

namespace SystemAPI.Entity
{
    public class SensorDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public SensorDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<SensorData> SensorData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
    }

}
