using Microsoft.EntityFrameworkCore;
using VendasWEB.Models;

namespace VendasWEB.Data
{
    public class WEBContext : DbContext
    {
        public WEBContext (DbContextOptions<WEBContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> Sales { get; set; }
    }
}
