using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MovieDbLib.Entities;
using System;
using System.Reflection;

namespace MovieDbLib
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Presentation> Presentations { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        class MovieContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
        {
            public MovieDbContext CreateDbContext(string[]? args = null)
            {
                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();
                optionsBuilder
                    // Uncomment the following line if you want to print generated
                    // SQL statements on the console.
                    // .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                    .UseMySql(configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 26))); 

                return new MovieDbContext(optionsBuilder.Options);
            }
        }
    }
}
