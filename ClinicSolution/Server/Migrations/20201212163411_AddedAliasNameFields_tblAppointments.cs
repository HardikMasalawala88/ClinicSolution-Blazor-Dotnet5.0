using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSolution.Server.Migrations
{
    public partial class AddedAliasNameFields_tblAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "tblAppointments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "tblAppointments");
        }
    }
}
