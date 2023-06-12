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
    [Migration("20230605161859_IdentityUpdate")]
    partial class IdentityUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProyectoRRHH.Models.candidato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("departamento")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("empresa")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("explaboral")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateOnly?>("fechadesde")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("fechahasta")
                        .HasColumnType("date");

                    b.Property<string>("nombre")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("puestoaspira")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("puestoocupado")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("recomendadopor")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("salario")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("salarioaspira")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("id")
                        .HasName("pk_candidatos_id");

                    b.HasIndex("departamento");

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

                    b.Property<int?>("candidato_id")
                        .HasColumnType("integer");

                    b.Property<string>("descripcion")
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

                    b.HasIndex("candidato_id");

                    b.ToTable("capacitaciones");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.competencia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descripcion")
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

            modelBuilder.Entity("ProyectoRRHH.Models.usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("emailnormalizado")
                        .HasColumnType("character varying");

                    b.Property<string>("password")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("id")
                        .HasName("pk_usuario_id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("candidatoscompetencia", b =>
                {
                    b.Property<int>("candidatoid")
                        .HasColumnType("integer");

                    b.Property<int>("competenciaid")
                        .HasColumnType("integer");

                    b.HasKey("candidatoid", "competenciaid")
                        .HasName("pk_candidatos_competencias");

                    b.HasIndex("competenciaid");

                    b.ToTable("candidatoscompetencias", (string)null);
                });

            modelBuilder.Entity("candidatosidioma", b =>
                {
                    b.Property<int>("candidatoid")
                        .HasColumnType("integer");

                    b.Property<int>("idiomasid")
                        .HasColumnType("integer");

                    b.HasKey("candidatoid", "idiomasid")
                        .HasName("pk_candidatos_idiomas");

                    b.HasIndex("idiomasid");

                    b.ToTable("candidatosidiomas", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoRRHH.Models.candidato", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.departamento", "departamentoNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("departamento")
                        .HasPrincipalKey("departamento1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_candidatos_departamento");

                    b.HasOne("ProyectoRRHH.Models.puesto", "puestoaspiraNavigation")
                        .WithMany("candidatos")
                        .HasForeignKey("puestoaspira")
                        .HasPrincipalKey("nombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_candidatos_puestoaspira");

                    b.Navigation("departamentoNavigation");

                    b.Navigation("puestoaspiraNavigation");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.capacitacione", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.candidato", "candidato")
                        .WithMany("capacitaciones")
                        .HasForeignKey("candidato_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("capacitaciones_candidato_id_fkey");

                    b.Navigation("candidato");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.empleado", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.candidato", "cedulaNavigation")
                        .WithOne("empleado")
                        .HasForeignKey("ProyectoRRHH.Models.empleado", "cedula")
                        .HasPrincipalKey("ProyectoRRHH.Models.candidato", "cedula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_empleados_cedula");

                    b.HasOne("ProyectoRRHH.Models.departamento", "departamentoNavigation")
                        .WithMany("empleados")
                        .HasForeignKey("departamento")
                        .HasPrincipalKey("departamento1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_empleados_departamento");

                    b.HasOne("ProyectoRRHH.Models.puesto", "puestoNavigation")
                        .WithMany("empleados")
                        .HasForeignKey("puesto")
                        .HasPrincipalKey("nombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_empleados_puesto");

                    b.Navigation("cedulaNavigation");

                    b.Navigation("departamentoNavigation");

                    b.Navigation("puestoNavigation");
                });

            modelBuilder.Entity("candidatoscompetencia", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.candidato", null)
                        .WithMany()
                        .HasForeignKey("candidatoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_candidatos_competencias_candidatoid");

                    b.HasOne("ProyectoRRHH.Models.competencia", null)
                        .WithMany()
                        .HasForeignKey("competenciaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_candidatos_competencias_competenciaid");
                });

            modelBuilder.Entity("candidatosidioma", b =>
                {
                    b.HasOne("ProyectoRRHH.Models.candidato", null)
                        .WithMany()
                        .HasForeignKey("candidatoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_candidatos_idiomas_candidatoid");

                    b.HasOne("ProyectoRRHH.Models.idioma", null)
                        .WithMany()
                        .HasForeignKey("idiomasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_candidatos_idiomas_idiomasid");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.candidato", b =>
                {
                    b.Navigation("capacitaciones");

                    b.Navigation("empleado");
                });

            modelBuilder.Entity("ProyectoRRHH.Models.departamento", b =>
                {
                    b.Navigation("candidatos");

                    b.Navigation("empleados");
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