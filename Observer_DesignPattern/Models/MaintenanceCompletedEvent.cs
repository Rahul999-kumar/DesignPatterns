using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Models
{
    public class MaintenanceCompletedEvent
    {
        public int AircraftId { get; set; }

        public string EngineerName { get; set; } = string.Empty;

        public DateTime CompletedOn { get; set; }
    }
}
