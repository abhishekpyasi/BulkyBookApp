using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyBookWeb.Migrations
{
    public partial class addApplicationTypeToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppliCationTypes",
                columns: table => new
                {
                    CategortId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliCationTypes", x => x.CategortId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppliCationTypes");
        }
    }
}
