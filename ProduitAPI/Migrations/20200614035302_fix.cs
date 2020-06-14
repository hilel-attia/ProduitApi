using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduitAPI.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactureFrs_Commande_frss_IdCO",
                table: "FactureFrs");

            migrationBuilder.DropIndex(
                name: "IX_FactureFrs_IdCO",
                table: "FactureFrs");

            migrationBuilder.DropColumn(
                name: "IdCO",
                table: "FactureFrs");

            migrationBuilder.AddColumn<Guid>(
                name: "IdFac",
                table: "Commande_frss",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Commande_frss_IdFac",
                table: "Commande_frss",
                column: "IdFac",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_frss_FactureFrs_IdFac",
                table: "Commande_frss",
                column: "IdFac",
                principalTable: "FactureFrs",
                principalColumn: "IdFac",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_frss_FactureFrs_IdFac",
                table: "Commande_frss");

            migrationBuilder.DropIndex(
                name: "IX_Commande_frss_IdFac",
                table: "Commande_frss");

            migrationBuilder.DropColumn(
                name: "IdFac",
                table: "Commande_frss");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCO",
                table: "FactureFrs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_FactureFrs_IdCO",
                table: "FactureFrs",
                column: "IdCO",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FactureFrs_Commande_frss_IdCO",
                table: "FactureFrs",
                column: "IdCO",
                principalTable: "Commande_frss",
                principalColumn: "IdCO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
