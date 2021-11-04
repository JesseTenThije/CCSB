using Microsoft.EntityFrameworkCore.Migrations;

namespace CCSB.Migrations
{
    public partial class Addedapplicationuseridtocrb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Crv",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Crv_ApplicationUserId",
                table: "Crv",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crv_AspNetUsers_ApplicationUserId",
                table: "Crv",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crv_AspNetUsers_ApplicationUserId",
                table: "Crv");

            migrationBuilder.DropIndex(
                name: "IX_Crv_ApplicationUserId",
                table: "Crv");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Crv");
        }
    }
}
