using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Model
{
    public class MediaConfig : IEntityTypeConfiguration<Media>
    {

        public void Configure(EntityTypeBuilder<Media> entity)
        {
            entity.HasKey(m => m.Id).IsClustered(true);
            entity.Property(m => m.Name).IsRequired()
                   .HasColumnType("nvarchar(50)")
                   .IsRequired(true)
                   .HasComment("Name of media item");
               entity.Property(m => m.Uri).IsRequired()
                    .HasColumnType("nvarchar(255)")
                    .HasComment("Uri of media item")
                    .IsUnicode(false);
            entity.HasIndex(m => m.Name).HasDatabaseName("idx_Media_Name");
        }
    }
}
