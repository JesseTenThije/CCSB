using Microsoft.EntityFrameworkCore.Migrations;

namespace CCSB.Migrations
{
    public partial class Fixedreserveringen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vehicle",
                table: "Reserveringen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vehicle",
                table: "Reserveringen",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
