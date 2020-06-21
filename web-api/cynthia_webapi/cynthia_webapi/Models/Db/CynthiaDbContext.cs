using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cynthia_webapi.Models.Db
{
    public partial class CynthiaDbContext : DbContext
    {
        public CynthiaDbContext()
        {
        }

        public CynthiaDbContext(DbContextOptions<CynthiaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FiverrItem> FiverrItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Cynthia;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FiverrItem>(entity =>
            {
                entity.HasIndex(e => e.Client)
                    .HasName("UQ__FiverrIt__0197BECC00D7D064")
                    .IsUnique();

                entity.HasIndex(e => e.DtmDeadline)
                    .HasName("UQ__FiverrIt__81FF17860AD75A09")
                    .IsUnique();

                entity.HasIndex(e => e.NvcDescription)
                    .HasName("UQ__FiverrIt__A165C1CFA203F956")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BitIsDone).HasColumnName("bitIsDone");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasColumnName("client")
                    .HasMaxLength(20);

                entity.Property(e => e.DtmDeadline)
                    .HasColumnName("dtmDeadline")
                    .HasMaxLength(20);

                entity.Property(e => e.IntPriority).HasColumnName("intPriority");

                entity.Property(e => e.NvcDescription)
                    .IsRequired()
                    .HasColumnName("nvcDescription")
                    .HasMaxLength(100);
            });
        }
    }
}
