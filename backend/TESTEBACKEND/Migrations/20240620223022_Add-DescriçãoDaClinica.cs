using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTEBACKEND.Migrations
{
    public partial class AddDescriçãoDaClinica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Clinicas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Clinicas");
        }
    }
}
