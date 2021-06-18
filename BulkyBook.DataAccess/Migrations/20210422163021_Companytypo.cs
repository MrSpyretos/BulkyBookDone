using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyBook.DataAccess.Migrations
{
    public partial class Companytypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAuthorrizedCompany",
                table: "Companies",
                newName: "IsAuthorizedCompany");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAuthorizedCompany",
                table: "Companies",
                newName: "IsAuthorrizedCompany");
        }
    }
}
