using AbstarctFactory_DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Models
{
    public class MaintenanceRequest
    {
        public int AircraftId { get; set; }

        public AirlineType AirlineType { get; set; }

        public string EngineerName { get; set; } = string.Empty;
    }
}
