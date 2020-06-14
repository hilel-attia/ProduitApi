using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduitAPI.Migrations
{
    public partial class relationpaquetartil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paquet",
                columns: table => new
                {
                    IdPA = table.Column<Guid>(nullable: false),
                    CodeFaq = table.Column<string>(nullable: true),
                    Epaisseur = table.Column<double>(nullable: false),
                    Largeur = table.Column<double>(nullable: false),
                    Longeur = table.Column<double>(nullable: false),
                    Quantite = table.Column<double>(nullable: false),
                    IdAR = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paquet", x => x.IdPA);
                    table.ForeignKey(
                        name: "FK_Paquet_Articles_IdAR",
                        column: x => x.IdAR,
                        principalTable: "Articles",
                        principalColumn: "IdAR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paquet_IdAR",
                table: "Paquet",
                column: "IdAR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paquet");
        }
    }
}
