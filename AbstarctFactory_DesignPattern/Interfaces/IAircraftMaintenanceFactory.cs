using AbstarctFactory_DesignPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctFactory_DesignPattern.Interfaces
{
    public interface IAircraftMaintenanceFactory
    {
        AirlineType AirlineType { get; }
        INotification CreateNotification();

        IReportGenerator CreateReport();

        IStorage CreateStorage();
    }
}
