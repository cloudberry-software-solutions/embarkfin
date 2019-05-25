using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace embarkfin.api.Migrations
{
    public partial class updateInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Disposal_DisposalId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset");

            migrationBuilder.AlterColumn<double>(
                name: "Purchase_Price",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "Period",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DisposalId",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_Purchased",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Disposal_DisposalId",
                table: "Asset",
                column: "DisposalId",
                principalTable: "Disposal",
                principalColumn: "DisposalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Disposal_DisposalId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset");

            migrationBuilder.AlterColumn<double>(
                name: "Purchase_Price",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Period",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisposalId",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_Purchased",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Disposal_DisposalId",
                table: "Asset",
                column: "DisposalId",
                principalTable: "Disposal",
                principalColumn: "DisposalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
