﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProyectoRRHH;

#nullable disable

namespace ProyectoRRHH.Migrations
{
    [DbContext(typeof(rrhhContext))]
    [Migration("20230517223529_user")]
    partial class user
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProyectoRRHH.Models.candidato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("capacitaciones")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("competencias")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("departamento")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("explaboral")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("nombre")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("puestoaspira")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("recomendadopor")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("salarioaspira")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("id")
                        .HasName("pk_candidatos_id");

                    b.HasIndex("capacitaciones");

                    b.HasIndex("competencias");

                    b.HasIndex("departamento");

                    b.HasIndex("explaboral");

                    b.HasIndex("puestoaspira");

                    b.HasIndex(new[] { "cedula" }, "uq_candidatos_cedula")
                        .IsUnique();

                    b.ToTable("candidatos");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.capacitacione", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateOnly?>("fechadesde")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("fechahasta")
                        .HasColumnType("date");

                    b.Property<string>("institucion")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("nivel")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("id")
                        .HasName("pk_capacitacion_id");

                    b.HasIndex(new[] { "descripcion" }, "uq_capacitaciones_descripcioncapacitacion")
                        .IsUnique();

                    b.ToTable("capacitaciones");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.competencia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool?>("estado")
                        .HasColumnType("boolean");

                    b.HasKey("id")
                        .HasName("pk_competencia_id");

                    b.HasIndex(new[] { "descripcion" }, "uq_competencias_descripcioncompetencia")
                        .IsUnique();

                    b.ToTable("competencias");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.departamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("departamento1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("departamento");

                    b.HasKey("id")
                        .HasName("pk_departamento_id");

                    b.HasIndex(new[] { "departamento1" }, "uq_departamentos_departamento")
                        .IsUnique();

                    b.ToTable("departamentos");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.empleado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("cedula")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("departamento")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("estado")
                        .HasColumnType("boolean");

                    b.Property<DateOnly?>("fechaingreso")
                        .HasColumnType("date");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("puesto")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("salariomensual")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("id")
                        .HasName("pk_empleados_id");

                    b.HasIndex("departamento");

                    b.HasIndex("puesto");

                    b.HasIndex(new[] { "cedula" }, "uq_empleados_cedula")
                        .IsUnique();

                    b.ToTable("empleados");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.explaboral", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("empresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateOnly?>("fechadesde")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("fechahasta")
                        .HasColumnType("date");

                    b.Property<string>("puestoocupado")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("salario")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("id")
                        .HasName("pk_explaboral_id");

                    b.HasIndex(new[] { "empresa" }, "uq_explaboral_empresa")
                        .IsUnique();

                    b.ToTable("explaboral", (string)null);
                });

            modelBuilder.Entity("ProyectoRRHH.Models.idioma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nivel")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("nombre")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("id")
                        .HasName("pk_idiomas_id");

                    b.HasIndex(new[] { "nombre" }, "uq_idiomas_nombre")
                        .IsUnique();

                    b.ToTable("idiomas");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.puesto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool?>("estado")
                        .HasColumnType("boolean");

                    b.Property<string>("nivelriesgo")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("salariomax")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("salariomin")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("id")
                        .HasName("pk_puesto_id");

                    b.HasIndex(new[] { "nombre" }, "uq_puestos_nombre")
                        .IsUnique();

                    b.ToTable("puestos");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.rol", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("id")
                        .HasName("rol_pkey");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("ProyectoRRHH.Models.usuario", b =>
                {
                    b.Property<string>("clave")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("correo")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("id")
                        .HasColumnType("integer");

                    b.Property<int?>("idrol")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasIndex("idrol");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.candidato", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.capacitacione", "capacitacionesNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("capacitaciones")
                        .HasPrincipalKey("descripcion")
                        .HasConstraintName("fk_candidatos_capacitaciones");

                    b.HasOne("ProyectoRRHH.Models.competencia", "competenciasNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("competencias")
                        .HasPrincipalKey("descripcion")
                        .HasConstraintName("fk_candidatos_competencias");

                    b.HasOne("ProyectoRRHH.Models.departamento", "departamentoNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("departamento")
                        .HasPrincipalKey("departamento1")
                        .HasConstraintName("fk_candidatos_departamento");

                    b.HasOne("ProyectoRRHH.Models.explaboral", "explaboralNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("explaboral")
                        .HasPrincipalKey("empresa")
                        .HasConstraintName("fk_candidatos_explaboral");

                    b.HasOne("ProyectoRRHH.Models.puesto", "puestoaspiraNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("puestoaspira")
                        .HasPrincipalKey("nombre")
                        .HasConstraintName("fk_candidatos_puestoaspira");

                    b.Navigation("capacitacionesNavigation");

                    b.Navigation("competenciasNavigation");

                    b.Navigation("departamentoNavigation");

                    b.Navigation("explaboralNavigation");

                    b.Navigation("puestoaspiraNavigation");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.empleado", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.candidato", "cedulaNavigation")
                        .WithOne("empleado")
                        .HasForeignKey("ProyectoRRHH.Models.empleado", "cedula")
                        .HasPrincipalKey("ProyectoRRHH.Models.candidato", "cedula")
                        .HasConstraintName("fk_empleados_cedula");

                    b.HasOne("ProyectoRRHH.Models.departamento", "departamentoNavigation")
                        .WithMany("empleados")
                        .HasForeignKey("departamento")
                        .HasPrincipalKey("departamento1")
                        .HasConstraintName("fk_empleados_departamento");

                    b.HasOne("ProyectoRRHH.Models.puesto", "puestoNavigation")
                        .WithMany("empleados")
                        .HasForeignKey("puesto")
                        .HasPrincipalKey("nombre")
                        .HasConstraintName("fk_empleados_puesto");

                    b.Navigation("cedulaNavigation");

                    b.Navigation("departamentoNavigation");

                    b.Navigation("puestoNavigation");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.usuario", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.rol", "idrolNavigation")
                        .WithMany()
                        .HasForeignKey("idrol")
                        .HasConstraintName("usuarios_idrol_fkey");

                    b.Navigation("idrolNavigation");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.candidato", b =>
                {
                    b.Navigation("empleado");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.capacitacione", b =>
                {
                    b.Navigation("candidatos");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.competencia", b =>
                {
                    b.Navigation("candidatos");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.departamento", b =>
                {
                    b.Navigation("candidatos");

                    b.Navigation("empleados");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.explaboral", b =>
                {
                    b.Navigation("candidatos");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.puesto", b =>
                {
                    b.Navigation("candidatos");

                    b.Navigation("empleados");
                });
#pragma warning restore 612, 618
        }
    }
}