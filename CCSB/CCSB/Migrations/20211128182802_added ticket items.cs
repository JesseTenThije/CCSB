using Microsoft.EntityFrameworkCore.Migrations;

namespace CCSB.Migrations
{
    public partial class addedticketitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CrvArico",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvBikes",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvBuildYear",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvDirtWater",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvKms",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvPks",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvPullingHook",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrvSleepingPlace",
                table: "Crv",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrvArico",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvBikes",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvBuildYear",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvDirtWater",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvKms",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvPks",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvPullingHook",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "CrvSleepingPlace",
                table: "Crv");
        }
    }
}
