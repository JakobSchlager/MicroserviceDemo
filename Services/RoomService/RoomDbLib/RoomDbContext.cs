using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RoomDbLib.Entities;
using System;
using System.Reflection;

namespace RoomDbLib
{
    public class RoomDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }

        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        class RoomContextFactory : IDesignTimeDbContextFactory<RoomDbContext>
        {
            public RoomDbContext CreateDbContext(string[]? args = null)
            {
                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                var optionsBuilder = new DbContextOptionsBuilder<RoomDbContext>();
                optionsBuilder
                    // Uncomment the following line if you want to print generated
                    // SQL statements on the console.
                    // .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                    .UseMySql(configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 26)));

                return new RoomDbContext(optionsBuilder.Options);
            }
        }
    }
}
