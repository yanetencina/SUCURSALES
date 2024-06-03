using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sucursales.Models;

public partial class SucursalesDbContext : DbContext
{
    public SucursalesDbContext()
    {
    }

    public SucursalesDbContext(DbContextOptions<SucursalesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sucursale> Sucursales { get; set; }

    
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("Server=Yanet\\SQLEXPRESS; DataBase=SucursalesDB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sucursale>(entity =>
        {
            entity.HasKey(e => e.SucursalId).HasName("PK__Sucursal__6CB48281384B8438");

            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.CodigoPostal).HasMaxLength(20);
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Gerente).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
