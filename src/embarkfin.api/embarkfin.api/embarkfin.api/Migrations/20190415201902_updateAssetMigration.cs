using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace embarkfin.api.Migrations
{
    public partial class updateAssetMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisposalId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Disposal",
                columns: table => new
                {
                    DisposalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Disposed_Date = table.Column<DateTime>(nullable: false),
                    Disposal_Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disposal", x => x.DisposalId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Longitude = table.Column<long>(nullable: false),
                    Latitude = table.Column<long>(nullable: false),
                    Date_Captured = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_DisposalId",
                table: "Asset",
                column: "DisposalId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_LocationId",
                table: "Asset",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Location_DisposalId",
                table: "Asset",
                column: "DisposalId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Disposal_LocationId",
                table: "Asset",
                column: "LocationId",
                principalTable: "Disposal",
                principalColumn: "DisposalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Location_DisposalId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Disposal_LocationId",
                table: "Asset");

            migrationBuilder.DropTable(
                name: "Disposal");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Asset_DisposalId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_LocationId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "DisposalId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Asset");
        }
    }
}
