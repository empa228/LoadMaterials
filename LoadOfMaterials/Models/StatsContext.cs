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

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    public virtual DbSet<WorkersShift> WorkersShifts { get; set; }

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
            entity.Property(e => e.IdShift).HasColumnName("Id_Shift");
            entity.Property(e => e.TimeNum).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.IdShiftNavigation).WithMany(p => p.LoadingMaterials)
                .HasForeignKey(d => d.IdShift)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_loading_to_shifts");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Shifts_pkey");

            entity.Property(e => e.DateEnd)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("Date_end");
            entity.Property(e => e.DateStart)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("Date_start");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Workers_pkey");

            entity.Property(e => e.DateOfBirth)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("Date_of_birth");
            entity.Property(e => e.JobTitle).HasColumnName("Job_title");
        });

        modelBuilder.Entity<WorkersShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Workers_shifts_pkey");

            entity.ToTable("Workers_shifts");

            entity.Property(e => e.IdShifts).HasColumnName("Id_shifts");
            entity.Property(e => e.IdWorkers).HasColumnName("Id_workers");

            entity.HasOne(d => d.IdShiftsNavigation).WithMany(p => p.WorkersShifts)
                .HasForeignKey(d => d.IdShifts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Workers_shifts_shifts");

            entity.HasOne(d => d.IdWorkersNavigation).WithMany(p => p.WorkersShifts)
                .HasForeignKey(d => d.IdWorkers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Workers_shifts_workers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
