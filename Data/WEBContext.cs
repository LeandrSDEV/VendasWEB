using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<VendasWEB.Models.Departamento> Departamento { get; set; } = default!;
    }
}
