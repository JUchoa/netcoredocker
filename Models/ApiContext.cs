using Microsoft.EntityFrameworkCore;

namespace netcoredocker.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options) => this.Database.EnsureCreated();

        public DbSet<Product> Products {get; set; }
        public DbSet<Client> Clients {get;set;}
    }
}