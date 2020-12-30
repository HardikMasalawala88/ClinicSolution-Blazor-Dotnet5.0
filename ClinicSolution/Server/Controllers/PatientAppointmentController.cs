using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicSolution.Server.Data;
using ClinicSolution.Shared.PatientAppointment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAppointmentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public PatientAppointmentController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var patientAppointment = await _context.tblPatientAppointments.ToListAsync();
            return Ok(patientAppointment);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var patientAppointment = await _context.tblPatientAppointments.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(patientAppointment);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PatientAppointment patientAppointment)
        {
            _context.Add(patientAppointment);
            await _context.SaveChangesAsync();
            return Ok(patientAppointment.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(PatientAppointment patientAppointment)
        {
            _context.Entry(patientAppointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var patientAppointment = new PatientAppointment { Id = id };
            _context.Remove(patientAppointment);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
