using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EsteEs.Migrations
{
    public partial class addidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Integrantes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sexo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    apellidos = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nombres = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    ciudad_nacimiento = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pais_residencia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    direccion = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    telefono = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    celular = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    correo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    tipo_doc_identidad = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    doc_identidad = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pais_nacimiento = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ciudad_residencia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Imagen = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrantes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "datos_academicos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_integrante = table.Column<int>(nullable: true),
                    nivel_estudio = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    expulsado = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datos_academicos", x => x.id);
                    table.ForeignKey(
                        name: "FK_datos_academicos_Integrantes",
                        column: x => x.id_integrante,
                        principalTable: "Integrantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "datos_eclesiasticos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_integrante = table.Column<int>(nullable: false),
                    fecha_conversion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_bautismo = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_aceptado = table.Column<DateTime>(type: "datetime", nullable: true),
                    denominacion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    nombre_iglesia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    congregacion_anterior = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    pastor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    disciplinado = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    disciplinado_veces = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    disciplinado_causas = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    funciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ministerios = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ministerios_mayor_fruto = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ministerios_llamado = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    metas = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    respaldo = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datos_eclesiasticos", x => x.id);
                    table.ForeignKey(
                        name: "FK_datos_eclesiasticos_Integrantes",
                        column: x => x.id_integrante,
                        principalTable: "Integrantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "datos_familiares",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_integrante = table.Column<int>(nullable: false),
                    estado_civil = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    hijos = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datos_familiares", x => x.id);
                    table.ForeignKey(
                        name: "Relacion Integrantes/Familiares",
                        column: x => x.id_integrante,
                        principalTable: "Integrantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "datos_laborales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_integrante = table.Column<int>(nullable: false),
                    profesion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    nombre_empresa = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ocupacion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    telefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datos_laborales", x => x.id);
                    table.ForeignKey(
                        name: "Tabla Laboral/Integrante",
                        column: x => x.id_integrante,
                        principalTable: "Integrantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_datos_academicos_id_integrante",
                table: "datos_academicos",
                column: "id_integrante");

            migrationBuilder.CreateIndex(
                name: "IX_datos_eclesiasticos_id_integrante",
                table: "datos_eclesiasticos",
                column: "id_integrante");

            migrationBuilder.CreateIndex(
                name: "IX_datos_familiares_id_integrante",
                table: "datos_familiares",
                column: "id_integrante");

            migrationBuilder.CreateIndex(
                name: "IX_datos_laborales_id_integrante",
                table: "datos_laborales",
                column: "id_integrante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "datos_academicos");

            migrationBuilder.DropTable(
                name: "datos_eclesiasticos");

            migrationBuilder.DropTable(
                name: "datos_familiares");

            migrationBuilder.DropTable(
                name: "datos_laborales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Integrantes");
        }
    }
}
