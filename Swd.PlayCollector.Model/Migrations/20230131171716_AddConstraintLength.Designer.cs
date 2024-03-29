﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Swd.PlayCollector.Model;

#nullable disable

namespace Swd.PlayCollector.Model.Migrations
{
    [DbContext(typeof(PlayCollectorContext))]
    [Migration("20230131171716_AddConstraintLength")]
    partial class AddConstraintLength
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Swd.PlayCollector.Model.CollectionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of collection item");

                    b.Property<string>("Number")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("Number of collection item");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(8,2)")
                        .HasDefaultValue(0m)
                        .HasComment("Price of collection item");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("LocationId");

                    b.HasIndex("Name")
                        .HasDatabaseName("idx_CollectionItem_Name");

                    b.HasIndex("ThemeId");

                    b.ToTable("CollectionItem");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CollectionItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of media item");

                    b.Property<int>("TypeOfDocumentId")
                        .HasColumnType("int");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Uri of media item");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("CollectionItemId");

                    b.HasIndex("Name")
                        .HasDatabaseName("idx_Media_Name");

                    b.HasIndex("TypeOfDocumentId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.TypeOfDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of document type");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("Name")
                        .HasDatabaseName("idx_TypeofDocument_Name");

                    b.ToTable("TypeOfDocument");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.CollectionItem", b =>
                {
                    b.HasOne("Swd.PlayCollector.Model.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("Swd.PlayCollector.Model.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId");

                    b.Navigation("Location");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.Media", b =>
                {
                    b.HasOne("Swd.PlayCollector.Model.CollectionItem", "CollectionItem")
                        .WithMany("MediaSet")
                        .HasForeignKey("CollectionItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Swd.PlayCollector.Model.TypeOfDocument", "TypeOfDocument")
                        .WithMany()
                        .HasForeignKey("TypeOfDocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CollectionItem");

                    b.Navigation("TypeOfDocument");
                });

            modelBuilder.Entity("Swd.PlayCollector.Model.CollectionItem", b =>
                {
                    b.Navigation("MediaSet");
                });
#pragma warning restore 612, 618
        }
    }
}
