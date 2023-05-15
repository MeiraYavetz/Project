using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entities;

namespace Context;

public partial class HmoMembersContext : DbContext,IContext
{
    public HmoMembersContext()
    {
    }

    public HmoMembersContext(DbContextOptions<HmoMembersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Vaccine> Vaccines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HMO_members;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_constraint_name");

            entity.ToTable("Member");

            entity.Property(e => e.Id)
                .HasMaxLength(9)
                .HasColumnName("id");
            entity.Property(e => e.Adress)
                .HasMaxLength(50)
                .HasColumnName("adress");
            entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasColumnName("birthDate");
            entity.Property(e => e.DateOfPositiveResult)
                .HasColumnType("date")
                .HasColumnName("dateOfPositiveResult");
            entity.Property(e => e.DateOfRecovery)
                .HasColumnType("date")
                .HasColumnName("dateOfRecovery");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("fullName");
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(10)
                .HasColumnName("mobilePhone");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Vaccine>(entity =>
        {
            entity.HasKey(e => e.IdVaccine);

            entity.ToTable("Vaccine");

            entity.Property(e => e.IdVaccine)
                .ValueGeneratedNever()
                .HasColumnName("idVaccine");
            entity.Property(e => e.DateOfVaccine)
                .HasColumnType("date")
                .HasColumnName("dateOfVaccine");
            entity.Property(e => e.IdMember)
                .HasMaxLength(9)
                .HasColumnName("idMember");
            entity.Property(e => e.VaccineManuFacturer)
                .HasMaxLength(50)
                .HasColumnName("vaccineManuFacturer");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
