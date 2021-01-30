using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSolution.Server.Migrations
{
    public partial class UpdatePatientAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "tblPatientAppointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DB",
                table: "tblPatientAppointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MiscellaneousAmount",
                table: "tblPatientAppointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "tblPatientAppointments");

            migrationBuilder.DropColumn(
                name: "DB",
                table: "tblPatientAppointments");

            migrationBuilder.DropColumn(
                name: "MiscellaneousAmount",
                table: "tblPatientAppointments");
        }
    }
}
