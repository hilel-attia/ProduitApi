using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduitAPI.Migrations
{
    public partial class FixarticleCommanderelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    IdAR = table.Column<Guid>(nullable: false),
                    Codeart = table.Column<string>(nullable: true),
                    Codetva = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Unite = table.Column<string>(nullable: true),
                    Fammile_art = table.Column<string>(nullable: true),
                    Taux_tva = table.Column<int>(nullable: false),
                    Remise = table.Column<int>(nullable: false),
                    Purbht = table.Column<double>(nullable: false),
                    Pudttc = table.Column<double>(nullable: false),
                    Purnht = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.IdAR);
                });

            migrationBuilder.CreateTable(
                name: "Commande_frss",
                columns: table => new
                {
                    IdCO = table.Column<Guid>(nullable: false),
                    Etatcmd = table.Column<string>(nullable: true),
                    Nomcmd = table.Column<string>(nullable: true),
                    Datecmd = table.Column<DateTime>(nullable: false),
                    Mntnet = table.Column<double>(nullable: false),
                    Mnttva = table.Column<double>(nullable: false),
                    IdAR = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande_frss", x => x.IdCO);
                    table.ForeignKey(
                        name: "FK_Commande_frss_Articles_IdAR",
                        column: x => x.IdAR,
                        principalTable: "Articles",
                        principalColumn: "IdAR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_frss_IdAR",
                table: "Commande_frss",
                column: "IdAR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commande_frss");

            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
