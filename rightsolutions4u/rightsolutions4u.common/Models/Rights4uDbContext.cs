using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rightsolutions4u.common.Models;

public partial class Rights4uDbContext : DbContext
{
    
    public Rights4uDbContext()
    {
    }

    public Rights4uDbContext(DbContextOptions<Rights4uDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contactus> Contactus { get; set; }

    public virtual DbSet<User> Users { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("Server=localhost; Database=rights4u_db;Uid=root;Pwd=Mohtashim098@;", ServerVersion.AutoDetect("Server=localhost; Database=rights4u_db;Uid=root;Pwd=Mohtashim098@;"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contactus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contactus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Endate)
                .HasColumnType("datetime")
                .HasColumnName("endate");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasColumnName("fullname");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(255)
                .HasColumnName("phoneno");
            entity.Property(e => e.Replied).HasColumnName("replied");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Endate)
                .HasColumnType("datetime")
                .HasColumnName("endate");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Latname)
                .HasMaxLength(255)
                .HasColumnName("latname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(255)
                .HasColumnName("phoneno");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
