using AppointmentScheduling.Core.Model.ScheduleAggregate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentScheduling.Core.Interfaces
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> List();
    }
}
