using Microsoft.EntityFrameworkCore;
using Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.DAL
{
    public class DataBaseContext : DbContext
    {
       

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base (options)
        {
            
        }

        public DbSet <ConcertDB> ConcertsDBs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entity>().HasIndex(c => c.Id).IsUnique();
        }

    }

}
