using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using Otus.Teaching.PromoCodeFactory.DataAccess.Data;
using Otus.Teaching.PromoCodeFactory.DataAccess.EntityConfigurations;

namespace Otus.Teaching.PromoCodeFactory.WebHost
{
    public class DataContext: DbContext
    {
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DataContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();    
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply entity configurations.
            modelBuilder.ApplyConfiguration(new PreferenceConfiguration());

            // Fill db by default data.
            modelBuilder.Entity<Role>().HasData(FakeDataFactory.Roles);
            modelBuilder.Entity<Preference>().HasData(FakeDataFactory.Preferences);
        }
    }
}
