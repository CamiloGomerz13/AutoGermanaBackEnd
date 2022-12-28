using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoGermanaBackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    idcategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    idproducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idcategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    codigo = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    precio_venta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    Categoriaidcategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.idproducto);
                    table.ForeignKey(
                        name: "FK_productos_categorias_Categoriaidcategoria",
                        column: x => x.Categoriaidcategoria,
                        principalTable: "categorias",
                        principalColumn: "idcategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productos_Categoriaidcategoria",
                table: "productos",
                column: "Categoriaidcategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
