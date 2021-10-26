using Microsoft.EntityFrameworkCore.Migrations;

namespace UGOZ_Marcel_Roesink.Migrations
{
    public partial class Voertuigenadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voertuigen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Merk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lengte = table.Column<int>(type: "int", nullable: false),
                    Stroom = table.Column<bool>(type: "bit", nullable: false),
                    Kenteken = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voertuigen", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voertuigen");
        }
    }
}
