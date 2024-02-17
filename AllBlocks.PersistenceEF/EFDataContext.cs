using AllBlocks.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBlocks.Persistence.EF
{
    public class EFDataContext : DbContext
    {
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Unit> Units { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BlocksDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
