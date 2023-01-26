using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Model
{
    public class TypeOfDocumentConfig : IEntityTypeConfiguration<TypeOfDocument>
    {

        public void Configure(EntityTypeBuilder<TypeOfDocument> entity)
        {
            entity.HasKey(m => m.Id).IsClustered(true);
            entity.Property(m => m.Name).IsRequired()
                   .HasColumnType("nvarchar(50)")
                   .IsRequired(true)
                   .HasComment("Name of document type")
                   .IsUnicode(false);
            entity.HasIndex(m => m.Name).HasDatabaseName("idx_TypeofDocument_Name");
        }
    }
}
