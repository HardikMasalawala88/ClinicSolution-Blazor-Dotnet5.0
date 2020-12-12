using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSolution.Server.Migrations
{
    public partial class AddedNewFields_tblAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClinicalMedicine",
                table: "tblAppointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prescription",
                table: "tblAppointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specification",
                table: "tblAppointments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClinicalMedicine",
                table: "tblAppointments");

            migrationBuilder.DropColumn(
                name: "Prescription",
                table: "tblAppointments");

            migrationBuilder.DropColumn(
                name: "Specification",
                table: "tblAppointments");
        }
    }
}
