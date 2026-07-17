using Observer_DesignPattern.Interfaces;
using Observer_DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_DesignPattern.Observers
{
    public class ReportObserver : IMaintenanceObserver
    {
        public async Task UpdateAsync(MaintenanceCompletedEvent maintenanceEvent)
        {
            Console.WriteLine(
                $"📄 PDF Report generated for Aircraft {maintenanceEvent.AircraftId}");

            await Task.CompletedTask;
        }
    }
}
