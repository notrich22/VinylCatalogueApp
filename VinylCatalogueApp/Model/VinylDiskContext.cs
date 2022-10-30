using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace VinylCatalogueApp.Model
{
    public class VinylDiskContext : DbContext
    {
        //Множество записей из базы
        public DbSet<VinylDisk> Disks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VinylDisksDB;Trusted_Connection=True;");
        }
    }
}
