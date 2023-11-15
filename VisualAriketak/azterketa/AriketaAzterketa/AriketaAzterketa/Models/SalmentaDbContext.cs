using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriketaAzterketa.Models
{
    internal class SalmentaDbContext : DbContext
    {
        public SalmentaDbContext() : base(nameOrConnectionString: "SalmentaDbContext")
        { }

        public DbSet<Botoa> Botoa { get; set; }
        public DbSet<Erabiltzailea> Erabiltzailea { get; set; }
        public DbSet<Errezeta> Errezeta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
