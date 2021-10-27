using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class ClothesRUSdemoContext : DbContext
    {
        public ClothesRUSdemoContext()
        {
        }

        public ClothesRUSdemoContext(DbContextOptions<ClothesRUSdemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clothing> Clothings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Clothing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Clothing");

                entity.Property(e => e.RestCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rest_city");

                entity.Property(e => e.RestName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rest_name");

                entity.Property(e => e.RestState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rest_state");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
