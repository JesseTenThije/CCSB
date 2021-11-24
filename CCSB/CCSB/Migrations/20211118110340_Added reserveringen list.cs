using Microsoft.EntityFrameworkCore.Migrations;

namespace CCSB.Migrations
{
    public partial class Addedreserveringenlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserveringen_Crv_CrvId",
                table: "Reserveringen");

            migrationBuilder.AlterColumn<int>(
                name: "CrvId",
                table: "Reserveringen",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserveringen_Crv_CrvId",
                table: "Reserveringen",
                column: "CrvId",
                principalTable: "Crv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserveringen_Crv_CrvId",
                table: "Reserveringen");

            migrationBuilder.AlterColumn<int>(
                name: "CrvId",
                table: "Reserveringen",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserveringen_Crv_CrvId",
                table: "Reserveringen",
                column: "CrvId",
                principalTable: "Crv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
