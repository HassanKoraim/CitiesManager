using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public ApplicationDbContext()
        {
            
        }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(new City { cityId = Guid.Parse("26ADAEB7-8854-4758-94D4-20B93F955B64"), cityName="Palstine"});
            modelBuilder.Entity<City>().HasData(new City { cityId = Guid.Parse("E3339BBE-8E81-4F1D-89CD-3A771DF8ED0B"), cityName="Egypt" });
        }

    }
}
