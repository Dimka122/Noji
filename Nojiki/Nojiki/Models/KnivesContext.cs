using Microsoft.EntityFrameworkCore;

namespace Nojiki.Models
{
    public class KnivesContext:DbContext
    {
        public DbSet<Knives> knivess { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Catalog=Kniv;Integrated Security=True;");
        }

    }
}
