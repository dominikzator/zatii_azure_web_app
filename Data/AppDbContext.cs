using Microsoft.EntityFrameworkCore;

namespace zatii_azure_web_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons{ get; set; }
    }
}
