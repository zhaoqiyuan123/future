using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Future.EFCore.Models
{
    public partial class linkContext : DbContext
    {
        public linkContext()
        {
        }

        public linkContext(DbContextOptions<linkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Link> Link { get; set; }
        public virtual DbSet<LinkUser> LinkUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=WIN-U6LR8RG8SAN\\SFMSSQLSERVER;database=link;uid=sa;pwd=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(32);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LongUrl)
                    .IsRequired()
                    .HasColumnName("long_url");

                entity.Property(e => e.ShortUrl)
                    .IsRequired()
                    .HasColumnName("short_url")
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LinkUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("link_user");

                entity.Property(e => e.AppId)
                    .IsRequired()
                    .HasColumnName("app_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(32);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(16);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasColumnName("pass_word")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
