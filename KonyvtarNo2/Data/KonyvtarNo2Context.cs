using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KonyvtarNo2Library.Models;

namespace KonyvtarNo2.Data
{
    public class KonyvtarNo2Context : DbContext
    {
        public KonyvtarNo2Context (DbContextOptions<KonyvtarNo2Context> options)
            : base(options)
        {
        }

        public KonyvtarNo2Context()
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
