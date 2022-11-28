using Microsoft.EntityFrameworkCore;

namespace Nojiki.Models
{
    public class KnivesContext:DbContext
    {
        public DbSet<Knives> knivess { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           optionsBuilder.UseSqlServer("Data Source=sql5107.site4now.net;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
