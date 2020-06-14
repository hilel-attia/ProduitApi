using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduitAPI.Migrations
{
    public partial class fixxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LigneFactureFrs",
                columns: table => new
                {
                    IdLi = table.Column<Guid>(nullable: false),
                    NumCMD = table.Column<double>(nullable: false),
                    Qte = table.Column<double>(nullable: false),
                    Taux_tva = table.Column<double>(nullable: false),
                    Puttcnet = table.Column<double>(nullable: false),
                    IdFac = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigneFactureFrs", x => x.IdLi);
                    table.ForeignKey(
                        name: "FK_LigneFactureFrs_FactureFrs_IdFac",
                        column: x => x.IdFac,
                        principalTable: "FactureFrs",
                        principalColumn: "IdFac",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LigneFactureFrs_IdFac",
                table: "LigneFactureFrs",
                column: "IdFac");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LigneFactureFrs");
        }
    }
}
