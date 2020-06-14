using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduitAPI.Migrations
{
    public partial class fixfournisseurCommaderelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdFO",
                table: "Commande_frss",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Fourniseurs",
                columns: table => new
                {
                    IdFO = table.Column<Guid>(nullable: false),
                    Codetva = table.Column<string>(nullable: true),
                    Codefrs = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    Raiso = table.Column<string>(nullable: true),
                    Tel1 = table.Column<string>(nullable: true),
                    Tel2 = table.Column<string>(nullable: true),
                    Timbre = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fourniseurs", x => x.IdFO);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_frss_IdFO",
                table: "Commande_frss",
                column: "IdFO");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_frss_Fourniseurs_IdFO",
                table: "Commande_frss",
                column: "IdFO",
                principalTable: "Fourniseurs",
                principalColumn: "IdFO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_frss_Fourniseurs_IdFO",
                table: "Commande_frss");

            migrationBuilder.DropTable(
                name: "Fourniseurs");

            migrationBuilder.DropIndex(
                name: "IX_Commande_frss_IdFO",
                table: "Commande_frss");

            migrationBuilder.DropColumn(
                name: "IdFO",
                table: "Commande_frss");
        }
    }
}
