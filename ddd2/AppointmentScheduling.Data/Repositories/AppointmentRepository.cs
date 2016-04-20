using AppointmentScheduling.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentScheduling.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly SchedulingContext _context;

        public AppointmentRepository(SchedulingContext context)
        {
            this._context = context;
        }

        public IEnumerable<Core.Model.ScheduleAggregate.Appointment> List()
        {
            return _context.Appointments.AsEnumerable();
        }
    }
}
