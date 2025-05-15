using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoadOfMaterials.Models;

public partial class StatsContext : DbContext
{
    public StatsContext()
    {
    }

    public StatsContext(DbContextOptions<StatsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoadingMaterial> LoadingMaterials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=stats;Username=postgres;Password=Lemon4ik62212006");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoadingMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("LoadingMaterials_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TimeNum).HasColumnType("timestamp without time zone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
