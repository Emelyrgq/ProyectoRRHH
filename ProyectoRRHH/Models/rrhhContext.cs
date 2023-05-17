﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoRRHH.Models;

public partial class rrhhContext : DbContext
{
    public rrhhContext()
    {
    }

    public rrhhContext(DbContextOptions<rrhhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<candidato> candidatos { get; set; }

    public virtual DbSet<capacitacione> capacitaciones { get; set; }

    public virtual DbSet<competencia> competencias { get; set; }

    public virtual DbSet<departamento> departamentos { get; set; }

    public virtual DbSet<empleado> empleados { get; set; }

    public virtual DbSet<explaboral> explaborals { get; set; }

    public virtual DbSet<idioma> idiomas { get; set; }

    public virtual DbSet<puesto> puestos { get; set; }

    public virtual DbSet<rol> rols { get; set; }

    public virtual DbSet<usuario> usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=rrhh;Username=postgres;Password=postgre");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<candidato>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_candidatos_id");

            entity.HasIndex(e => e.cedula, "uq_candidatos_cedula").IsUnique();

            entity.Property(e => e.capacitaciones).HasMaxLength(60);
            entity.Property(e => e.cedula).HasMaxLength(30);
            entity.Property(e => e.competencias).HasMaxLength(60);
            entity.Property(e => e.departamento).HasMaxLength(30);
            entity.Property(e => e.explaboral).HasMaxLength(50);
            entity.Property(e => e.nombre).HasMaxLength(60);
            entity.Property(e => e.puestoaspira).HasMaxLength(50);
            entity.Property(e => e.recomendadopor).HasMaxLength(60);
            entity.Property(e => e.salarioaspira).HasMaxLength(10);

            entity.HasOne(d => d.capacitacionesNavigation).WithMany(p => p.candidatos)
                .HasPrincipalKey(p => p.descripcion)
                .HasForeignKey(d => d.capacitaciones)
                .HasConstraintName("fk_candidatos_capacitaciones");

            entity.HasOne(d => d.competenciasNavigation).WithMany(p => p.candidatos)
                .HasPrincipalKey(p => p.descripcion)
                .HasForeignKey(d => d.competencias)
                .HasConstraintName("fk_candidatos_competencias");

            entity.HasOne(d => d.departamentoNavigation).WithMany(p => p.candidatos)
                .HasPrincipalKey(p => p.departamento1)
                .HasForeignKey(d => d.departamento)
                .HasConstraintName("fk_candidatos_departamento");

            entity.HasOne(d => d.explaboralNavigation).WithMany(p => p.candidatos)
                .HasPrincipalKey(p => p.empresa)
                .HasForeignKey(d => d.explaboral)
                .HasConstraintName("fk_candidatos_explaboral");

            entity.HasOne(d => d.puestoaspiraNavigation).WithMany(p => p.candidatos)
                .HasPrincipalKey(p => p.nombre)
                .HasForeignKey(d => d.puestoaspira)
                .HasConstraintName("fk_candidatos_puestoaspira");
        });

        modelBuilder.Entity<capacitacione>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_capacitacion_id");

            entity.HasIndex(e => e.descripcion, "uq_capacitaciones_descripcioncapacitacion").IsUnique();

            entity.Property(e => e.descripcion).HasMaxLength(100);
            entity.Property(e => e.institucion).HasMaxLength(50);
            entity.Property(e => e.nivel).HasMaxLength(20);
        });

        modelBuilder.Entity<competencia>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_competencia_id");

            entity.HasIndex(e => e.descripcion, "uq_competencias_descripcioncompetencia").IsUnique();

            entity.Property(e => e.descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<departamento>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_departamento_id");

            entity.HasIndex(e => e.departamento1, "uq_departamentos_departamento").IsUnique();

            entity.Property(e => e.departamento1)
                .HasMaxLength(50)
                .HasColumnName("departamento");
        });

        modelBuilder.Entity<empleado>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_empleados_id");

            entity.HasIndex(e => e.cedula, "uq_empleados_cedula").IsUnique();

            entity.Property(e => e.cedula).HasMaxLength(30);
            entity.Property(e => e.departamento).HasMaxLength(50);
            entity.Property(e => e.nombre).HasMaxLength(50);
            entity.Property(e => e.puesto).HasMaxLength(50);
            entity.Property(e => e.salariomensual).HasMaxLength(10);

            entity.HasOne(d => d.cedulaNavigation).WithOne(p => p.empleado)
                .HasPrincipalKey<candidato>(p => p.cedula)
                .HasForeignKey<empleado>(d => d.cedula)
                .HasConstraintName("fk_empleados_cedula");

            entity.HasOne(d => d.departamentoNavigation).WithMany(p => p.empleados)
                .HasPrincipalKey(p => p.departamento1)
                .HasForeignKey(d => d.departamento)
                .HasConstraintName("fk_empleados_departamento");

            entity.HasOne(d => d.puestoNavigation).WithMany(p => p.empleados)
                .HasPrincipalKey(p => p.nombre)
                .HasForeignKey(d => d.puesto)
                .HasConstraintName("fk_empleados_puesto");
        });

        modelBuilder.Entity<explaboral>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_explaboral_id");

            entity.ToTable("explaboral");

            entity.HasIndex(e => e.empresa, "uq_explaboral_empresa").IsUnique();

            entity.Property(e => e.empresa).HasMaxLength(100);
            entity.Property(e => e.puestoocupado).HasMaxLength(100);
            entity.Property(e => e.salario).HasMaxLength(20);
        });

        modelBuilder.Entity<idioma>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_idiomas_id");

            entity.HasIndex(e => e.nombre, "uq_idiomas_nombre").IsUnique();

            entity.Property(e => e.nivel).HasMaxLength(20);
            entity.Property(e => e.nombre).HasMaxLength(20);
        });

        modelBuilder.Entity<puesto>(entity =>
        {
            entity.HasKey(e => e.id).HasName("pk_puesto_id");

            entity.HasIndex(e => e.nombre, "uq_puestos_nombre").IsUnique();

            entity.Property(e => e.nivelriesgo).HasMaxLength(10);
            entity.Property(e => e.nombre).HasMaxLength(50);
            entity.Property(e => e.salariomax).HasMaxLength(20);
            entity.Property(e => e.salariomin).HasMaxLength(20);
        });

        modelBuilder.Entity<rol>(entity =>
        {
            entity.HasKey(e => e.id).HasName("rol_pkey");

            entity.ToTable("rol");

            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<usuario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.clave).HasMaxLength(50);
            entity.Property(e => e.correo).HasMaxLength(50);
            entity.Property(e => e.nombre).HasMaxLength(50);

            entity.HasOne(d => d.idrolNavigation).WithMany()
                .HasForeignKey(d => d.idrol)
                .HasConstraintName("usuarios_idrol_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
