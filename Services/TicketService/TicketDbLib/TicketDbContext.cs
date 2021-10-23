using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using TicketDbLib.Entities;

namespace TicketDbLib
{
    public class TicketDbContext : DbContext
    {
            public DbSet<Ticket> Tickets { get; set; }

            public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }

            class TicketContextFactory : IDesignTimeDbContextFactory<TicketDbContext>
            {
                public TicketDbContext CreateDbContext(string[]? args = null)
                {
                    var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                    var optionsBuilder = new DbContextOptionsBuilder<TicketDbContext>();
                    optionsBuilder
                        // Uncomment the following line if you want to print generated
                        // SQL statements on the console.
                        // .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                        .UseMySql(configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 26)));

                    return new TicketDbContext(optionsBuilder.Options);
                }
            }
        }
    }

