using ApplicationForm.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationForm.DAL.Ef {
    public class Context : DbContext {

        public Context() {
              Database.EnsureCreated();
        }
        
        public DbSet<Application> applications { get; set; }
        public DbSet<ApplicationRequest> requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=Kraken");
        }
     

    }
}
