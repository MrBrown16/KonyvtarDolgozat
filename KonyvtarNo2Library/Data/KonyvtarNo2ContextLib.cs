using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarNo2Library.Data
{
    public class KonyvtarNo2ContextLib : DbContext
    {
        public KonyvtarNo2ContextLib(DbContextOptions<KonyvtarNo2ContextLib> options)
            : base(options)
        {
        }

        public KonyvtarNo2ContextLib()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=KonyvtarNo2.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<KonyvtarNo2Library.Models.Kolcsonzes> Kolcsonzes { get; set; } = default!;

        public DbSet<KonyvtarNo2Library.Models.Kolcsonzo>? Kolcsonzo { get; set; }
    }
}
