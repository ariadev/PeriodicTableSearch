using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PeriodicTableSearch.Data
{
    public partial class PeriodicElementsDbContext : DbContext
    {
        public PeriodicElementsDbContext()
        {
        }

        public PeriodicElementsDbContext(DbContextOptions<PeriodicElementsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PeriodicElement> PeriodicElements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // warning To protect potentially sensitive information in your connection string,
                // you should move it out of source code.
                // You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration
                // - see https://go.microsoft.com/fwlink/?linkid=2131148.
                // For more guidance on storing connection strings,
                // see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=periodic-elements.db;Cache=Shared");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeriodicElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("periodic-elements");

                entity.Property(e => e.AtomicMass).HasColumnType("varchar(300)");

                entity.Property(e => e.AtomicNumber).HasColumnType("varchar(300)");

                entity.Property(e => e.AtomicRadius).HasColumnType("varchar(300)");

                entity.Property(e => e.BoilingPoint).HasColumnType("varchar(300)");

                entity.Property(e => e.Density).HasColumnType("varchar(300)");

                entity.Property(e => e.Discoverer).HasColumnType("varchar(300)");

                entity.Property(e => e.Electronegativity).HasColumnType("varchar(300)");

                entity.Property(e => e.Element).HasColumnType("varchar(300)");

                entity.Property(e => e.FirstIonization).HasColumnType("varchar(300)");

                entity.Property(e => e.Group).HasColumnType("varchar(300)");

                entity.Property(e => e.MeltingPoint).HasColumnType("varchar(300)");

                entity.Property(e => e.Metal).HasColumnType("varchar(300)");

                entity.Property(e => e.Metalloid).HasColumnType("varchar(300)");

                entity.Property(e => e.Natural).HasColumnType("varchar(300)");

                entity.Property(e => e.Nonmetal).HasColumnType("varchar(300)");

                entity.Property(e => e.NumberOfIsotopes).HasColumnType("varchar(300)");

                entity.Property(e => e.NumberofElectrons).HasColumnType("varchar(300)");

                entity.Property(e => e.NumberofNeutrons).HasColumnType("varchar(300)");

                entity.Property(e => e.NumberofProtons).HasColumnType("varchar(300)");

                entity.Property(e => e.NumberofShells).HasColumnType("varchar(300)");

                entity.Property(e => e.NumberofValence).HasColumnType("varchar(300)");

                entity.Property(e => e.Period).HasColumnType("varchar(300)");

                entity.Property(e => e.Phase).HasColumnType("varchar(300)");

                entity.Property(e => e.Radioactive).HasColumnType("varchar(300)");

                entity.Property(e => e.SpecificHeat).HasColumnType("varchar(300)");

                entity.Property(e => e.Symbol).HasColumnType("varchar(300)");

                entity.Property(e => e.Type).HasColumnType("varchar(300)");

                entity.Property(e => e.Year).HasColumnType("varchar(300)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
