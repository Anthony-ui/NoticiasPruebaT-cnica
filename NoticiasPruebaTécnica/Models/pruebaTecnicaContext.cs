using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NoticiasPruebaTécnica.Models
{
    public partial class pruebaTecnicaContext : DbContext
    {
        public pruebaTecnicaContext()
        {
        }

        public pruebaTecnicaContext(DbContextOptions<pruebaTecnicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NoticiasEventos> NoticiasEventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<NoticiasEventos>(entity =>
            {
                entity.HasKey(e => e.IdNoticia)
                    .HasName("PK__Noticias__F682B59E7B9B7DA5");

                entity.Property(e => e.IdNoticia).HasColumnName("idNoticia");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("imagen");

                entity.Property(e => e.Noticia)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("noticia");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
