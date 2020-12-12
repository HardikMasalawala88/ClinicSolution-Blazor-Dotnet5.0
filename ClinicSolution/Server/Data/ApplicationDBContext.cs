﻿using ClinicSolution.Shared.Appointment;
using ClinicSolution.Shared.Disease;
using ClinicSolution.Shared.Patient;
using Microsoft.EntityFrameworkCore;

namespace ClinicSolution.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Appointment> tblAppointments { get; set; }
        public virtual DbSet<Disease> tblDiseases { get; set; }
        public virtual DbSet<Patient> tblPatients { get; set; }

    }
}
