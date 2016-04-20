using AppointmentScheduling.Core.Model.Events;
using FrontDesk.SharedKernel.Interfaces;
using System;
using System.Linq;

namespace AppointmentScheduling.Core.Services
{
    /// <summary>
    /// Sample for a Slide
    /// </summary>
    public class RelayAppointmentScheduledService : IHandle<AppointmentScheduledEvent>
    {
        public void Handle(AppointmentScheduledEvent domainEvent)
        {
            dynamic newEvent = new
            {
                Start = domainEvent.AppointmentScheduled.TimeRange.Start,
                End = domainEvent.AppointmentScheduled.TimeRange.End,
                Client = "",
                Patient = "",
                AppointmentType = "",
                Doctor = ""
            };

            #region Fetch the Client name, Patient name, Appointment Type, and Doctor information
            #endregion

            #region Publish the newEvent to a message bus for other systems to consume
            newEvent.ToString(); // added just to remove green squiggles in above code
            #endregion
        }
    }
}
