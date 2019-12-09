using Learning.CoreMvc.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Learning.CoreMvc.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public readonly DbContextOptions ContextOptions;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            ContextOptions = dbContextOptions;
        }

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile("appsettings.Development.json", true)
                    .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ApplicationContext"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
