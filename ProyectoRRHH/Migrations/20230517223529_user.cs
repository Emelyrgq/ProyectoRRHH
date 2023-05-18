using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProyectoRRHH.Migrations
{
    /// <inheritdoc />
    public partial class user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "capacitaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nivel = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    fechadesde = table.Column<DateOnly>(type: "date", nullable: true),
                    fechahasta = table.Column<DateOnly>(type: "date", nullable: true),
                    institucion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_capacitacion_id", x => x.id);
                    table.UniqueConstraint("AK_capacitaciones_descripcion", x => x.descripcion);
                });

            migrationBuilder.CreateTable(
                name: "competencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_competencia_id", x => x.id);
                    table.UniqueConstraint("AK_competencias_descripcion", x => x.descripcion);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    departamento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_departamento_id", x => x.id);
                    table.UniqueConstraint("AK_departamentos_departamento", x => x.departamento);
                });

            migrationBuilder.CreateTable(
                name: "explaboral",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    empresa = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    puestoocupado = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    fechadesde = table.Column<DateOnly>(type: "date", nullable: true),
                    fechahasta = table.Column<DateOnly>(type: "date", nullable: true),
                    salario = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_explaboral_id", x => x.id);
                    table.UniqueConstraint("AK_explaboral_empresa", x => x.empresa);
                });

            migrationBuilder.CreateTable(
                name: "idiomas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    nivel = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_idiomas_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "puestos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    nivelriesgo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    salariomin = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    salariomax = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_puesto_id", x => x.id);
                    table.UniqueConstraint("AK_puestos_nombre", x => x.nombre);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rol_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cedula = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    nombre = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    puestoaspira = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    departamento = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    salarioaspira = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    competencias = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    capacitaciones = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    explaboral = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    recomendadopor = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidatos_id", x => x.id);
                    table.UniqueConstraint("AK_candidatos_cedula", x => x.cedula);
                    table.ForeignKey(
                        name: "fk_candidatos_capacitaciones",
                        column: x => x.capacitaciones,
                        principalTable: "capacitaciones",
                        principalColumn: "descripcion");
                    table.ForeignKey(
                        name: "fk_candidatos_competencias",
                        column: x => x.competencias,
                        principalTable: "competencias",
                        principalColumn: "descripcion");
                    table.ForeignKey(
                        name: "fk_candidatos_departamento",
                        column: x => x.departamento,
                        principalTable: "departamentos",
                        principalColumn: "departamento");
                    table.ForeignKey(
                        name: "fk_candidatos_explaboral",
                        column: x => x.explaboral,
                        principalTable: "explaboral",
                        principalColumn: "empresa");
                    table.ForeignKey(
                        name: "fk_candidatos_puestoaspira",
                        column: x => x.puestoaspira,
                        principalTable: "puestos",
                        principalColumn: "nombre");
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: true),
                    nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    correo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    clave = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    idrol = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "usuarios_idrol_fkey",
                        column: x => x.idrol,
                        principalTable: "rol",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cedula = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    fechaingreso = table.Column<DateOnly>(type: "date", nullable: true),
                    departamento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    puesto = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    salariomensual = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_empleados_id", x => x.id);
                    table.ForeignKey(
                        name: "fk_empleados_cedula",
                        column: x => x.cedula,
                        principalTable: "candidatos",
                        principalColumn: "cedula");
                    table.ForeignKey(
                        name: "fk_empleados_departamento",
                        column: x => x.departamento,
                        principalTable: "departamentos",
                        principalColumn: "departamento");
                    table.ForeignKey(
                        name: "fk_empleados_puesto",
                        column: x => x.puesto,
                        principalTable: "puestos",
                        principalColumn: "nombre");
                });

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_capacitaciones",
                table: "candidatos",
                column: "capacitaciones");

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_competencias",
                table: "candidatos",
                column: "competencias");

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_departamento",
                table: "candidatos",
                column: "departamento");

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_explaboral",
                table: "candidatos",
                column: "explaboral");

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_puestoaspira",
                table: "candidatos",
                column: "puestoaspira");

            migrationBuilder.CreateIndex(
                name: "uq_candidatos_cedula",
                table: "candidatos",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_capacitaciones_descripcioncapacitacion",
                table: "capacitaciones",
                column: "descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_competencias_descripcioncompetencia",
                table: "competencias",
                column: "descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_departamentos_departamento",
                table: "departamentos",
                column: "departamento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empleados_departamento",
                table: "empleados",
                column: "departamento");

            migrationBuilder.CreateIndex(
                name: "IX_empleados_puesto",
                table: "empleados",
                column: "puesto");

            migrationBuilder.CreateIndex(
                name: "uq_empleados_cedula",
                table: "empleados",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_explaboral_empresa",
                table: "explaboral",
                column: "empresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_idiomas_nombre",
                table: "idiomas",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uq_puestos_nombre",
                table: "puestos",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_idrol",
                table: "usuarios",
                column: "idrol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "idiomas");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "candidatos");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "capacitaciones");

            migrationBuilder.DropTable(
                name: "competencias");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "explaboral");

            migrationBuilder.DropTable(
                name: "puestos");
        }
    }
}
