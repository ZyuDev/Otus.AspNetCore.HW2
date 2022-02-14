using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using Otus.Teaching.PromoCodeFactory.DataAccess.EntityConfigurations;

namespace Otus.Teaching.PromoCodeFactory.WebHost
{
    public class DataContext: DbContext
    {
        public DbSet<Preference> Preferences { get; set; }

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
            modelBuilder.ApplyConfiguration(new PreferenceConfiguration());
        }
    }
}
