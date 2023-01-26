using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Swd.PlayCollector.Model
{
    public class PlayCollectorContext: DbContext
    {

        public DbSet<CollectionItem> CollectionItem { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "data source=.;initial catalog=Swd.PlayCollector;integrated security=True;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<CollectionItem>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.Property(k => k.Name).IsRequired();
            //});
            modelBuilder.ApplyConfiguration(new CollectionItemConfig());
            modelBuilder.ApplyConfiguration(new MediaConfig());
            modelBuilder.ApplyConfiguration(new TypeOfDocumentConfig());

        }




    }
}