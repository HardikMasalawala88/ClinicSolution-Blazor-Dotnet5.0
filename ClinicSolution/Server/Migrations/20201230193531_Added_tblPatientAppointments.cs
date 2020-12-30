using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSolution.Server.Migrations
{
    public partial class Added_tblPatientAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPatientAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Complaints = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicalMedicine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstPrescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondPrescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatientAppointments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPatientAppointments");
        }
    }
}
