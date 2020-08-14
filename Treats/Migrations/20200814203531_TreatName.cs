using Microsoft.EntityFrameworkCore.Migrations;

namespace Treats.Migrations
{
    public partial class TreatName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TreatDescription",
                table: "Treats",
                newName: "TreatName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TreatName",
                table: "Treats",
                newName: "TreatDescription");
        }
    }
}
